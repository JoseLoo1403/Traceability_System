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

namespace Traceability_System.Forms.EntitiesViews
{
    public partial class LogRecordView : UserControl
    {
        LogRecordRepository repository = new LogRecordRepository();
        public LogRecordView()
        {
            InitializeComponent();
        }

        private void LogRecordView_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void LoadRecords()
        {
            LogGv.DataSource = null;
            LogGv.DataSource = repository.GetAllLogRecord();
            LogGv.Refresh();
        }
    }
}
