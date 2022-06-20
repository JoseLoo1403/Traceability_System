using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traceability_System.Helpers;
using Traceability_System.Forms;
using Traceability_System.Modbus;

namespace Traceability_System.Forms.PieceScanSelectionViews
{
    public partial class SelectGenerationForm : UserControl
    {
        GlobalContextInfo ContextInfo;
        ModbusMasterConnector Connector;
        public SelectGenerationForm(GlobalContextInfo info, ModbusMasterConnector con)
        {
            InitializeComponent();
            ContextInfo = info;
            Connector = con;
        }

        private void BtnGen1_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo,1, Connector));
        }

        private void BtnGen2_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new PieceScanForm(ContextInfo, 2, Connector));
        }
    }
}
