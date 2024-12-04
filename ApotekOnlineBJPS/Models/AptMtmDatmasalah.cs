using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmDatmasalah
    {
        public string Nomtm { get; set; } = null!;
        public string Idmasalah { get; set; } = null!;
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptMtmRefmasalah IdmasalahNavigation { get; set; } = null!;
        public virtual AptMtmDatmtm NomtmNavigation { get; set; } = null!;
    }
}
