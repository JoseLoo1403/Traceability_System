using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traceability_System.Models;
using Traceability_System.Repositories;
using Traceability_System.Helpers;

namespace Traceability_System.Forms
{
    public partial class AddSerialNumberForm : UserControl
    {
        GlobalContextInfo ContextInfo;
        SerialNumber SearchedSerialNumber;
        public AddSerialNumberForm(GlobalContextInfo info)
        {
            InitializeComponent();
            ContextInfo = info;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SerialNumberRepository repository = new SerialNumberRepository();

            Piece piece = GetRelatedPiece();

            if (piece == null)
            {
                //No se encontro ninguna pieza
                ChangeGuideText("No se encontro ninguna pieza para asociar", Color.Red);
                return;
            }

            try
            {
                SerialNumber serialNumberAdder = new SerialNumber()
                {
                    SerialNumber1 = Convert.ToInt32(TxtSerialNumber.Text),
                    DaysEnable = Convert.ToInt32(TxtDays.Value),
                    CreatedDate = DateFormatHelper.GetCurrentDate(),
                    Active = true,
                    PieceId = piece.Id,
                    UserId = Convert.ToInt32(ContextInfo.CurrentUser.UserCode)
                };

                repository.AddSerialNumber(serialNumberAdder);
            }
            catch (Exception ex)
            {
                ChangeGuideText("Ocurrio un error agregando el numero serial: " + ex.Message, Color.Red);
                return;
            }

            ChangeGuideText("El numero serial fue agregado correctamente", Color.Green);
            ClearTextBoxes();
        }

        private Piece GetRelatedPiece()
        {
            PiecesRepository repository = new PiecesRepository();

            var result = ChkSecondGen.Checked ? 
                repository.GetPieceByPartNumberAndFinishedGood(TxtPiecePartNumber.Text, Convert.ToInt32(TxtFinishedGood.Text)) :
                repository.GetPieceByPartNumber(TxtPiecePartNumber.Text);

            return result;
        }

        private void BtnDeactivate_Click(object sender, EventArgs e)
        {
            if (SearchedSerialNumber == null)
            {
                return;
            }

            SerialNumberRepository repository = new SerialNumberRepository();

            if (SearchedSerialNumber.Active == true)
            {
                repository.ChangeStateBySerialNumber(SearchedSerialNumber.SerialNumber1, false);
                ChangeGuideText("Numero serial deshabilitado exitosamente", Color.Green);
            }
            else
            {
                repository.ChangeStateBySerialNumber(SearchedSerialNumber.SerialNumber1, true);
                ChangeGuideText("Numero serial habilitado exitosamente", Color.Green);
            }

            SearchedSerialNumber = null;
            TxtDeactivateSerial.Clear();
        }

        private void ChangeGuideText(string text, Color color)
        {
            var t = new Timer();
            t.Interval = 4000;

            LblGuide.Text = text;
            LblGuide.ForeColor = color;

            t.Tick += (s, e) =>
            {
                LblGuide.Text = "";
                t.Stop();
            };
            t.Start();
        }

        private void ClearTextBoxes()
        {
            TxtPiecePartNumber.Clear();
            TxtDays.Value = 0;
            TxtSerialNumber.Clear();
            TxtFinishedGood.Clear();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SerialNumberRepository repository = new SerialNumberRepository();

            var result = repository.GetSerialNumberByNumber(Convert.ToInt32(TxtDeactivateSerial.Text));

            if (result == null)
            {
                //No se encontro ningun numero serial
                ChangeGuideText("El numero serial que ingreso no existe", Color.Red);
                TxtDeactivateSerial.Clear();
                return;
            }
            else
            {
                string activateText = result.Active == true ? "Habilitado" : "Deshabilitado";
                ChangeGuideText($"Numero serial [{result.SerialNumber1}] esta {activateText}", Color.Black);
            }

            if (result.Active == true)
            {
                BtnDeactivate.Text = "Deshabilitar";
            }
            else
            {
                BtnDeactivate.Text = "Habilitar";
            }

            SearchedSerialNumber = result;
        }

        private void ChkSecondGen_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSecondGen.Checked == true)
            {
                TxtFinishedGood.Enabled = true;
            }
            else
            {
                TxtFinishedGood.Enabled = false;
            }
        }
    }
}
