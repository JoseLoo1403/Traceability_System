using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Helpers;
using Traceability_System.Models;

namespace Traceability_System.Repositories
{
    public class LogRecordRepository
    {
        Traceability_System_DbContext context;
        public LogRecordRepository()
        {
            context = new Traceability_System_DbContext();
        }

        public void AddScannedPieces(List<Piece> pieces, List<int> serialNumbers, int userCode)
        {
            LogRecord LogRecordAdder = new LogRecord();

            DateTime date = DateTime.Now;
            date = new DateTime(date.Ticks - (date.Ticks % TimeSpan.TicksPerSecond), date.Kind);

            for (int i = 0; i < 3; i++)
            {
                LogRecordAdder.PieceId = pieces[i].Id;
                LogRecordAdder.PieceSerialNumber = serialNumbers[i];
                LogRecordAdder.UserId = userCode;
                LogRecordAdder.Date = date;
                context.Add(LogRecordAdder);
                context.SaveChanges();
            }
        }
    }
}
