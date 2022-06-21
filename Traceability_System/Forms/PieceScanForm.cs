using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traceability_System.Forms.PieceScanSelectionViews;
using Traceability_System.Helpers;
using Traceability_System.Models;
using Traceability_System.Repositories;
using Traceability_System.Modbus;

namespace Traceability_System.Forms
{
    public partial class PieceScanForm : UserControl
    {
        GlobalContextInfo ContextInfo;
        PiecesRepository repository;
        bool ScanMode = true; //True is for PartNumber and False for SerialNumber
        List<Piece> ScannedPieces = new List<Piece>();
        List<int> SerialNumbers = new List<int>();
        int CurrentGeneration;
        int CurrentComponentNumber = 1;
        int FinishGood;
        int CurrentPieceId = 0;
        ModbusMasterConnector connector { get; set; }

        public PieceScanForm(GlobalContextInfo info, int generation, ModbusMasterConnector con)
        {
            InitializeComponent();
            ContextInfo = info;
            repository = new PiecesRepository();
            CurrentGeneration = generation;
            LblGeneration.Text = $"Generacion {generation}";
            connector = con;

            if (generation == 1)
            {
                LblFinishGood.Hide();
                TxtFinishGood.Hide();
            }

            if (!connector.IsReading)
            {
                connector.StartConnection();
            }
        }

        private void ValidateInfoForPartNumber()
        {
            if (CurrentComponentNumber == 4)
            {
                //Process finish 
                TimerScan.Stop();
                UpdatePiecesState();
                ContextInfo.OpenNewFormEvent(new ScannedPiecesEndForm(ScannedPieces, ContextInfo, CurrentGeneration,SerialNumbers, connector));
                return;
            }

            if (string.IsNullOrEmpty(TxtPartNumber.Text))
            {
                return;
            }

            var Piece = CurrentGeneration == 1 ? 
                repository.GetPieceByPartNumber(TxtPartNumber.Text) : 
                repository.GetPieceByPartNumberAndFinishedGood(TxtPartNumber.Text,FinishGood);


            if (Piece == null)
            {
                //Piece not found in database

                if (CurrentGeneration == 2)
                {
                    if (!ValidateGeneration())
                    {
                        //Different generation detected for second gen scanning process
                        SendModbusSignal(Color.Red);
                        ContextInfo.AuthorizationRequiredEvent("authorization");
                        return;
                    }

                    if (!ValidateExistance())
                    {
                        //Piece
                        SendModbusSignal(Color.Red);
                        ContextInfo.AuthorizationRequiredEvent("authorization2");
                        return;
                    }
                }

                if (CurrentGeneration == 1)
                {
                    ChangeTextMainGuide("No se encontro ninguna pieza con ese codigo", Color.Red);
                }
                else
                {
                    ChangeTextMainGuide($"Codigo [{FinishGood}] no contiene ninguna pieza con ese codigo", Color.Red);
                }
                return;
            }
            else
            {
                //Piece founded
                ValidateScannedPiece(Piece);
                return;
            }
        }

        private void ValidateScannedPiece(Piece piece)
        {
            if (piece.Generation != CurrentGeneration)
            {
                //Different generation detected
                SendModbusSignal(Color.Red);
                ContextInfo.AuthorizationRequiredEvent("authorization");
                return;
            }

            //Validate days
            if (!DaysEnableValidator((int)piece.DaysEnable,(DateTime)piece.CreatedDate))
            {
                ChangeTextMainGuide("Esta pieza a expirado", Color.Red);
                if (piece.Active == true)
                {
                    repository.UpdatePieceActive(piece.Id);
                }
                return;
            }

            if (piece.Active == false)
            {
                ChangeTextMainGuide("Esta pieza a expirado", Color.Red);
                return;
            }

            if (piece.ComponentNumber != CurrentComponentNumber)
            {
                //Not correct order of piece
                ChangeTextMainGuide($"No se puede escanear esta pieza", Color.Red);
                return;
            }

            ScannedPieces.Add(piece);
            ScanMode = false;
            CurrentPieceId = piece.Id;
            ChangeTextMainGuide($"Pieza {piece.PieceName} escaneada correctamente", Color.Green);
        }

        private bool ValidateGeneration()
        {
            var result = repository.GetPieceByPartNumber(TxtPartNumber.Text);

            if (result == null)
            {
                return true;
            }

            if (result.Generation != CurrentGeneration && result.FinishedGood == null)
            {
                return false;
            }

            return true;
        }

        public bool ValidateExistance()
        {
            var result = repository.GetPieceByPartNumberAndGeneration(TxtPartNumber.Text,2);

            if (result == null)
            {
                return false;
            }

            return  true;
        }
        private void ValidateInfoForSerialNumber()
        {
            if (string.IsNullOrEmpty(TxtSerialNumber.Text)) { return; }

            if (GetAndValidateSerialNumber())
            {
                SerialNumbers.Add(Convert.ToInt32(TxtSerialNumber.Text));
                TxtSerialNumber.Clear();
                ScanMode = true;
                CurrentComponentNumber++;
                LblComponent.Text = $"Componente #{CurrentComponentNumber}";
                ChangeTextMainGuide("Codigo serial escaneado correctamente", Color.Green);
                TxtPartNumber.Clear();
                SendModbusSignal(Color.Green);
            }
        }

        public void SendModbusSignal(Color color)
        {
            if (!connector.IsReading)
            {
                connector.StartConnection();
            }
            if (color == Color.Green)
            {
                connector.ModbusGreenLightOn();
            }
            else
            {
                connector.ModbusRedLightOn();
            }
        }
        private bool GetAndValidateSerialNumber()
        {
            SerialNumberRepository repo = new SerialNumberRepository();

            var serialNumber = repo.GetSerialNumberByNumber(Convert.ToInt32(TxtSerialNumber.Text));

            if (serialNumber == null)
            {
                ChangeTextMainGuide("Este numero serial existe", Color.Red);
                return false;
            }

            if (serialNumber.PieceId != CurrentPieceId)
            {
                ChangeTextMainGuide("Este numero serial no pertenece a esta pieza", Color.Red);
                return false;
            }

            //Logica de dias habiles
            if (!DaysEnableValidator((int)serialNumber.DaysEnable,(DateTime)serialNumber.CreatedDate))
            {
                ChangeTextMainGuide($"El numero serial [{serialNumber.SerialNumber1}] ha expirado", Color.Red);
                if (serialNumber.Active == true)
                {
                    repo.ChangeStateBySerialNumber(serialNumber.SerialNumber1, false);
                }
                return false;
            }

            if (serialNumber.Active == false)
            {
                ChangeTextMainGuide($"El numero serial esta deshabiliado", Color.Red);
                return false;
            }

            return true;
        }

        private void ValidateInfoForFinishGood()
        {
            if (string.IsNullOrEmpty(TxtFinishGood.Text))
            {
                return;
            }

            try
            {
                if (repository.FinishGoodExist(Convert.ToInt32(TxtFinishGood.Text)))
                {
                    FinishGood = Convert.ToInt32(TxtFinishGood.Text);
                    TxtFinishGood.Hide();
                    LblFinishGood.Hide();
                    ChangeTextMainGuide("Codigo escaneado correctamente", Color.Green);
                }
                else
                {
                    ChangeTextMainGuide($"El codigo {TxtFinishGood.Text} no existe", Color.Red);
                }
            }
            catch (Exception)
            {
                ChangeTextMainGuide("Ocurrio un error", Color.Red);
                throw;
            }
        }

        private bool DaysEnableValidator(int Days, DateTime CreatedDate)
        {
            DateTime Today = DateTime.Now;
            DateTime ExpirationDate = CreatedDate.AddDays(Days);

            if (Today >= ExpirationDate)
            {
                //El codigo serial vencio
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ChangeTextMainGuide(string text, Color color)
        {
            var t = new Timer();
            t.Interval = 2000;

            LblMainGuide.Text = text;
            LblMainGuide.ForeColor = color;

            t.Tick += (s, e) =>
            {
                LblMainGuide.Text = "";
                t.Stop();
            };
            t.Start();
        }

        private void UpdatePiecesState()
        {
            PiecesRepository repo = new PiecesRepository();
            LogRecordRepository logRepo = new LogRecordRepository();

            repo.UpdateScannedPieces(ScannedPieces, ContextInfo.CurrentUser.UserCode);
            logRepo.AddScannedPieces(ScannedPieces, SerialNumbers, ContextInfo.CurrentUser.UserCode);

        }

        private void TimerScan_Tick(object sender, EventArgs e)
        {
            if (CurrentGeneration == 2 && FinishGood == 0)
            {
                ValidateInfoForFinishGood();
                TxtFinishGood.Clear();
                TxtFinishGood.Focus();
                return;
            }

            if (ScanMode)
            {
                TxtPartNumber.Focus();
                ValidateInfoForPartNumber();
                if (ScanMode)
                {
                    TxtPartNumber.Clear();
                }
            }
            else
            {
                ValidateInfoForSerialNumber();
                TxtSerialNumber.Clear();
                TxtSerialNumber.Focus();
            }
        }
    }
}
