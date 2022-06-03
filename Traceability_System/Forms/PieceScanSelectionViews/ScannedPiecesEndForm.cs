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

namespace Traceability_System.Forms.PieceScanSelectionViews
{
    public partial class ScannedPiecesEndForm : UserControl
    {
        List<Piece> ScannedPieces;
        GlobalContextInfo ContextInfo;
        int Gen;
        public ScannedPiecesEndForm(List<Piece> pieces, GlobalContextInfo info, int generation)
        {
            InitializeComponent();
            ScannedPieces = pieces;
            ContextInfo = info;
            Gen = generation;
        }

        private void ScannedPiecesEndForm_Load(object sender, EventArgs e)
        {
            PiecesGv.DataSource = ScannedPieces;
            //PiecesGv.Columns["User"].Visible = false;
            LblGeneration.Text = $"Generacion {Gen}";
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo, Gen));
        }
    }
}
