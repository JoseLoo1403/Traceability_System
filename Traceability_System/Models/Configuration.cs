using System;
using System.Collections.Generic;

#nullable disable

namespace Traceability_System.Models
{
    public partial class Configuration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
