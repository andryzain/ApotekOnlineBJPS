using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatbafiltrasi
    {
        public string Nopbk { get; set; } = null!;
        public string Idfiltrasi { get; set; } = null!;
        public DateTime Tglfiltrasi { get; set; }
        public int? Kasus { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptRefjnsfiltrasi IdfiltrasiNavigation { get; set; } = null!;
    }
}
