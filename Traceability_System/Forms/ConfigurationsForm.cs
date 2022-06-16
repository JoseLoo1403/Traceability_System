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
    }
}
