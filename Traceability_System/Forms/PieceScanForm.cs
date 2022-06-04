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

        public PieceScanForm(GlobalContextInfo info, int generation)
        {
            InitializeComponent();
            ContextInfo = info;
            repository = new PiecesRepository();
            CurrentGeneration = generation;
            LblGeneration.Text = $"Generacion {generation}";
        }

        private void ValidateInfoForPartNumber()
        {
            if (CurrentComponentNumber == 4)
            {
                //Process finish 
                TimerScan.Stop();
                UpdatePiecesState();
                ContextInfo.OpenNewFormEvent(new ScannedPiecesEndForm(ScannedPieces, ContextInfo, CurrentGeneration));
                return;
            }

            if (string.IsNullOrEmpty(TxtPartNumber.Text))
            {
                return;
            }

            var Piece = repository.GetPieceByPartNumber(TxtPartNumber.Text);

            if (Piece == null)
            {
                //Piece not found in database
                ChangeTextMainGuide("No se encontro ninguna pieza con ese codigo", Color.Red);
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
                ContextInfo.AuthorizationRequiredEvent("authorization");
                return;
            }

            if (piece.Active == false)
            {
                ChangeTextMainGuide("Esta pieza ya ha sido escaneada", Color.Red);
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
            ChangeTextMainGuide($"Pieza {piece.PieceName} escaneada correctamente", Color.Green);
        }

        private void ValidateInfoForSerialNumber()
        {
            if (string.IsNullOrEmpty(TxtSerialNumber.Text)) { return; }

            SerialNumbers.Add(Convert.ToInt32(TxtSerialNumber.Text));

            TxtSerialNumber.Clear();
            ScanMode = true;
            CurrentComponentNumber++;
            LblComponent.Text = $"Componente #{CurrentComponentNumber}";
            ChangeTextMainGuide("Codigo serial escaneado correctamente", Color.Green);
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
            if (ScanMode)
            {
                ValidateInfoForPartNumber();
                TxtPartNumber.Clear();
                TxtPartNumber.Focus();
            }
            else
            {
                ValidateInfoForSerialNumber();
                TxtSerialNumber.Focus();
            }
        }
    }
}
