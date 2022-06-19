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
            var result = FormatInfo();
            LogGv.DataSource = null;
            LogGv.DataSource = result;
            LogGv.Refresh();
        }

        private List<LogRecordFormatModel> FormatInfo()
        {
            var RawInfo = repository.GetAllLogRecord();

            LogRecordFormatModel adder;
            List<LogRecordFormatModel> Result = new List<LogRecordFormatModel>();

            foreach (var x in RawInfo)
            {
                adder = new LogRecordFormatModel()
                {
                    PiecePartNumber = x.Piece.PiecePartNumber,
                    SerialNumber = (int)x.PieceSerialNumber,
                    ScannedUser = x.UserId,
                    ScannedDate = (DateTime)x.Date
                };

                Result.Add(adder);
            }

            return Result;
        }
    }
}
