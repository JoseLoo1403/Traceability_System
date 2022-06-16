using System;
using System.Collections.Generic;

#nullable disable

namespace Traceability_System.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Users = new HashSet<User>();
        }

        public string Shift1 { get; set; }
        public TimeSpan HourStart { get; set; }
        public TimeSpan HourEnd { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
