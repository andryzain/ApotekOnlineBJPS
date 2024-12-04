using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmDatgroupmasalah
    {
        public string Nomtm { get; set; } = null!;
        public string Idgroupmasalah { get; set; } = null!;
        public string? Keterangan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptMtmDatmtm NomtmNavigation { get; set; } = null!;
    }
}
