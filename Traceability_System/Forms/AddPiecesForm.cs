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
using Traceability_System.Forms.EntitiesViews;

namespace Traceability_System.Forms
{
    public partial class AddPiecesForm : UserControl
    {
        GlobalContextInfo ContextInfo;
        Piece UpdatePiece;
        public AddPiecesForm(GlobalContextInfo info)
        {
            InitializeComponent();
            ContextInfo = info;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PiecesRepository repository = new PiecesRepository();

            try
            {
                Piece PieceAdder = new Piece()
                {
                    PieceName = TxtName.Text,
                    PiecePartNumber = TxtPartNumber.Text,
                    ComponentNumber = GetComponentNumber(),
                    Generation = Convert.ToInt32(TxtGeneration.Text),
                    FinishedGood = TxtFinishGood.Enabled == true ? Convert.ToInt32(TxtFinishGood.Text) : null,
                    Active = true,
                    DaysEnable = Convert.ToInt32(TxtDays.Text),
                    CreatedDate = DateFormatHelper.GetCurrentDate()
                };

                repository.AddPiece(PieceAdder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ChangeTextMainGuide("Ocurrio un error agregando la pieza", Color.Red);
                ClearTextBoxes();
                return;
            }

            ClearTextBoxes();
            ChangeTextMainGuide("La pieza fue agregada correctamente", Color.Green);
        }

        private void ClearTextBoxes()
        {
            TxtPartNumber.Clear();
            TxtGeneration.Text  = "";
            TxtFinishGood.Clear();
            TxtDays.Text = "";
        }

        private int GetComponentNumber()
        {
            switch (TxtName.SelectedItem)
            {
                case "Housing":
                    return 1;
                case "CPA":
                    return 2;
                case "Cover":
                    return 3;
            }

            return 0;
        }

        private void TxtGeneration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtGeneration.Text == "1")
            {
                TxtFinishGood.Enabled = false;
            }
            else
            {
                TxtFinishGood.Enabled = true;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            PiecesRepository repository = new PiecesRepository();

            Piece Remover = repository.GetPieceByPartNumber(TxtDeletePartNumber.Text);

            if (Remover == null)
            {
                ChangeTextMainGuide("No se encontro ninguna pieza con ese numero de parte", Color.Red);
                TxtDeletePartNumber.Clear();
                return;
            }

            try
            {
                repository.DeletePiece(Remover);
            }
            catch (Exception ex)
            {
                ChangeTextMainGuide("Ocurrio un error elimnando la pieza", Color.Red);
            }

            ChangeTextMainGuide("La pieza se elimino correctamente", Color.Green);
            TxtDeletePartNumber.Clear();
        }

        private void BtnViewPieces_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new PiecesTableView());
        }

        private void BtnSerialNumbersView_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new AddSerialNumberForm(ContextInfo));
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            PiecesRepository repository = new PiecesRepository();

            var result = ChkSecondGen.Checked ?
                repository.GetPieceByPartNumberAndFinishedGood(TxtDeletePartNumber.Text, Convert.ToInt32(TxtUpdateFinishedGood.Text)) :
                repository.GetPieceByPartNumber(TxtDeletePartNumber.Text);

            if (result == null)
            {
                ChangeTextMainGuide("No se encontro ningua pieza", Color.Red);
                return;
            }

            UpdatePiece = result;

            if (result.Active == true)
            {
                BtnActive.Text = "Deshabilitar";
            }
            else
            {
                var expire = (DateTime)result.CreatedDate;
                expire = expire.AddDays((int)result.DaysEnable);
                if (expire < DateTime.Now)
                {
                    BtnActive.Text = "Habilitar por un dia"; 
                }
                else
                {
                    BtnActive.Text = "Habilitar";
                }
            }
        }

        private void ChkSecondGen_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSecondGen.Checked == true)
            {
                TxtUpdateFinishedGood.Enabled = true;
            }
            else
            {
                TxtUpdateFinishedGood.Enabled = false;
            }
        }

        private void ClearUpdateTextBoxes()
        {
            TxtDeletePartNumber.Clear();
            TxtUpdateFinishedGood.Clear();
        }

        private void BtnActive_Click(object sender, EventArgs e)
        {
            PiecesRepository repository = new PiecesRepository();

            if (UpdatePiece == null)
            {
                //No se ha buscado pieza
                ChangeTextMainGuide("No se ha buscado ninguna pieza", Color.Red);
                return;
            }

            if (UpdatePiece.Active == true)
            {
                repository.UpdatePieceActive(UpdatePiece.Id);
                ChangeTextMainGuide("Pieza deshabilitada", Color.Green);
            }
            else
            {
                var expire = (DateTime)UpdatePiece.CreatedDate;
                expire = expire.AddDays((int)UpdatePiece.DaysEnable);

                if (expire < DateTime.Now)
                {
                    repository.ActivePieceForOneDay(UpdatePiece);
                    ChangeTextMainGuide("Pieza habilitada por un Dia", Color.Green); 
                }
                else
                {
                    repository.UpdatePieceActive(UpdatePiece.Id);
                    ChangeTextMainGuide("Pieza habilitada", Color.Green);
                }
            }

            ClearUpdateTextBoxes();
        }
    }
}
