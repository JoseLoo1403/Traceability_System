using System;
using System.Collections.Generic;

#nullable disable

namespace Traceability_System.Models
{
    public partial class LogRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PieceId { get; set; }
        public int? PieceSerialNumber { get; set; }
        public DateTime? Date { get; set; }

        public virtual Piece Piece { get; set; }
        public virtual User User { get; set; }
    }
}
