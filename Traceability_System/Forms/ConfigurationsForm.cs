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
using Traceability_System.Modbus;

namespace Traceability_System.Forms
{
    public partial class ConfigurationsForm : UserControl
    {
        GlobalContextInfo ContextInfo;
        public ConfigurationsForm(GlobalContextInfo info)
        {
            InitializeComponent();

            ContextInfo = info;
        }

        private void BtnShifts_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new ShiftsForm(ContextInfo));
        }

        private void BtnVerify_Click(object sender, EventArgs e)
        {
            ModbusMasterConnector c = new ModbusMasterConnector();

            var ipFormat = Encoding.ASCII.GetBytes(TxtIp.Text);
            c.StartConnection(TxtIp.Text, Convert.ToInt32(TxtPort.Text));

            c.WriteRegister(1);
        }
    }
}
