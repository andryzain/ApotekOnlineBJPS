using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmDatgroupmasalah
    {
        [Key]
        public Guid AptMtmDatgroupmasalahId { get; set; }
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
