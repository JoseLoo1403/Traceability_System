using System;
using System.Collections.Generic;

#nullable disable

namespace Traceability_System.Models
{
    public partial class User
    {
        public User()
        {
            LogRecords = new HashSet<LogRecord>();
            Pieces = new HashSet<Piece>();
        }

        public int Id { get; set; }
        public string UserCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public bool? Active { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual ICollection<LogRecord> LogRecords { get; set; }
        public virtual ICollection<Piece> Pieces { get; set; }
    }
}
