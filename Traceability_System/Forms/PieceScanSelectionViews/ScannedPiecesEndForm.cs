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
using Traceability_System.Modbus;

namespace Traceability_System.Forms.PieceScanSelectionViews
{
    public partial class ScannedPiecesEndForm : UserControl
    {
        List<Piece> ScannedPieces;
        List<int> SerialNumbers;
        GlobalContextInfo ContextInfo;
        int Gen;
        ModbusMasterConnector connector;

        public ScannedPiecesEndForm(List<Piece> pieces, GlobalContextInfo info, int generation, List<int> serialNumbers, ModbusMasterConnector con)
        {
            InitializeComponent();
            ScannedPieces = pieces;
            ContextInfo = info;
            Gen = generation;
            SerialNumbers = serialNumbers;
            connector = con;
        }

        private void ScannedPiecesEndForm_Load(object sender, EventArgs e)
        {
            LoadInfoGv();
            LblGeneration.Text = $"Generacion {Gen}";
        }

        private void LoadInfoGv()
        {
            PiecesGv.DataSource = FormatInformation();
            if (Gen == 1)
            {
                PiecesGv.Columns["FinishedGood"].Visible = false;
            }
        }

        public List<EndScannedModel> FormatInformation()
        {
            List<EndScannedModel> result = new List<EndScannedModel>();

            for (int i = 0; i < 3; i++)
            {
                EndScannedModel adder = new EndScannedModel(ScannedPieces[i],SerialNumbers[i]);
                result.Add(adder);
            }

            return result;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo, Gen, connector));
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            if (Gen == 1)
            {
                ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo, 2, connector)); 
            }
            else
            {
                ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo, 1, connector));
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            ContextInfo.UserLogoutEvent();
        }
    }
}
