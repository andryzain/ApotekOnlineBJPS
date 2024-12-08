using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmDatobat
    {
        [Key]
        public Guid AptMtmDatobatId { get; set; }
        public string Nomtm { get; set; } = null!;
        public string Idgroupmasalah { get; set; } = null!;
        public string Kdobat { get; set; } = null!;
        public string? Nmobat { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptMtmRefgroupmasalah IdgroupmasalahNavigation { get; set; } = null!;
    }
}
