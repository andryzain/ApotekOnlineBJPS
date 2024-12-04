using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmRefgroupmasalah
    {
        public AptMtmRefgroupmasalah()
        {
            AptMtmDatobats = new HashSet<AptMtmDatobat>();
            AptMtmRefmasalahs = new HashSet<AptMtmRefmasalah>();
        }

        public string Idgroupmasalah { get; set; } = null!;
        public string? Nmgroupmasalah { get; set; }
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual ICollection<AptMtmDatobat> AptMtmDatobats { get; set; }
        public virtual ICollection<AptMtmRefmasalah> AptMtmRefmasalahs { get; set; }
    }
}
