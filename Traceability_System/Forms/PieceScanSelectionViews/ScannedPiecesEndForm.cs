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
            LoadInfoGv();
            LblGeneration.Text = $"Generacion {Gen}";
        }

        private void LoadInfoGv()
        {
            PiecesGv.DataSource = ScannedPieces;
            if (Gen == 1)
            {
                PiecesGv.Columns["FinishedGood"].Visible = false;
            }
            PiecesGv.Columns["Active"].Visible = false;
            PiecesGv.Columns["DaysEnable"].Visible = false;
            PiecesGv.Columns["CreatedDate"].Visible = false;
            PiecesGv.Columns["UserScanned"].Visible = false;
            PiecesGv.Columns["ScannedDate"].Visible = false;
            PiecesGv.Columns["UserScannedNavigation"].Visible = false;
            PiecesGv.Columns["LogRecords"].Visible = false;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo, Gen));
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo, 2));
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            ContextInfo.UserLogoutEvent();
        }
    }
}
