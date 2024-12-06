using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptDatnofpkHist
    {
        [Key]
        public Guid AptDatnofpkHistId { get; set; }
        public string Nofpk { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime? Fdate { get; set; }
    }
}
