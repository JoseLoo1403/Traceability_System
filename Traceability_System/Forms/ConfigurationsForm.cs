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
using Traceability_System.Repositories;

namespace Traceability_System.Forms
{
    public partial class ConfigurationsForm : UserControl
    {
        GlobalContextInfo ContextInfo;
        ModbusMasterConnector c = new ModbusMasterConnector();
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
            try
            {
                if (!c.IsReading)
                {
                    c.StartConnection(TxtIp.Text, Convert.ToInt32(TxtPort.Text));
                }
                c.TryGreenLight();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ConfigurationRepository repository = new ConfigurationRepository();

            repository.UpdateConfiguration("Ip", TxtIp.Text);
            repository.UpdateConfiguration("Port", TxtPort.Text);

            TxtPort.Clear();
            TxtIp.Clear();
        }
    }
}
