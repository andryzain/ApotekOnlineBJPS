using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmDatmtm
    {
        public AptMtmDatmtm()
        {
            AptMtmDatgroupmasalahs = new HashSet<AptMtmDatgroupmasalah>();
            AptMtmDatmasalahs = new HashSet<AptMtmDatmasalah>();
        }

        public string Nomtm { get; set; } = null!;
        public DateTime? Tglmtm { get; set; }
        public string Nosjp { get; set; } = null!;
        public string? Nohp { get; set; }
        public int Flagmtm { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual ICollection<AptMtmDatgroupmasalah> AptMtmDatgroupmasalahs { get; set; }
        public virtual ICollection<AptMtmDatmasalah> AptMtmDatmasalahs { get; set; }
    }
}
