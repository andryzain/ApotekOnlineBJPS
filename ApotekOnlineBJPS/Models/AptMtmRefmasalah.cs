using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmRefmasalah
    {
        public AptMtmRefmasalah()
        {
            AptMtmDatmasalahs = new HashSet<AptMtmDatmasalah>();
        }

        public string Idgroupmasalah { get; set; } = null!;
        public string Idmasalah { get; set; } = null!;
        public string Nmmasalah { get; set; } = null!;
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptMtmRefgroupmasalah IdgroupmasalahNavigation { get; set; } = null!;
        public virtual ICollection<AptMtmDatmasalah> AptMtmDatmasalahs { get; set; }
    }
}
