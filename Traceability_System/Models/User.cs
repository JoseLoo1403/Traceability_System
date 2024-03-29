﻿using System;
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
            SerialNumbers = new HashSet<SerialNumber>();
        }

        public int UserCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Shift { get; set; }
        public bool Active { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual Shift ShiftNavigation { get; set; }
        public virtual ICollection<LogRecord> LogRecords { get; set; }
        public virtual ICollection<Piece> Pieces { get; set; }
        public virtual ICollection<SerialNumber> SerialNumbers { get; set; }
    }
}
