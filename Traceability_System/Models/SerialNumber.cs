using System;
using System.Collections.Generic;

#nullable disable

namespace Traceability_System.Models
{
    public partial class SerialNumber
    {
        public int SerialNumber1 { get; set; }
        public int? DaysEnable { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PieceId { get; set; }
        public int? UserId { get; set; }

        public virtual Piece Piece { get; set; }
        public virtual User User { get; set; }
    }
}
