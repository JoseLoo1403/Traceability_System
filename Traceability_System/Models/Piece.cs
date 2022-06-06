using System;
using System.Collections.Generic;

#nullable disable

namespace Traceability_System.Models
{
    public partial class Piece
    {
        public Piece()
        {
            LogRecords = new HashSet<LogRecord>();
        }

        public int Id { get; set; }
        public string PieceName { get; set; }
        public string PiecePartNumber { get; set; }
        public int? ComponentNumber { get; set; }
        public int? Generation { get; set; }
        public int? FinishedGood { get; set; }
        public bool? Active { get; set; }
        public int? DaysEnable { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UserScanned { get; set; }
        public DateTime? ScannedDate { get; set; }

        public virtual User UserScannedNavigation { get; set; }
        public virtual ICollection<LogRecord> LogRecords { get; set; }
    }
}
