using System;
using System.Collections.Generic;

#nullable disable

namespace Traceability_System.Models
{
    public partial class Piece
    {
        public int Id { get; set; }
        public string PieceName { get; set; }
        public int? PiecePartNumber { get; set; }
        public int? PieceSerialNumber { get; set; }
        public int? ComponentNumber { get; set; }
        public int? Generation { get; set; }
        public bool? Active { get; set; }
        public int? DaysEnable { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UserScanned { get; set; }
        public DateTime? ScannedDate { get; set; }

        public virtual User UserScannedNavigation { get; set; }
    }
}
