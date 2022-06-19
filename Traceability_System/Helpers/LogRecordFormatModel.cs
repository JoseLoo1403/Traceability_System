using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traceability_System.Helpers
{
    public class LogRecordFormatModel
    {
        public string PiecePartNumber { get; set; }
        public int SerialNumber { get; set; }
        public int ScannedUser { get; set; }
        public DateTime ScannedDate { get; set; }
    }
}
