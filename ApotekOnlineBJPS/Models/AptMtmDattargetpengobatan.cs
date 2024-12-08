using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmDattargetpengobatan
    {
        [Key]
        public Guid AptMtmDattargetpengobatanId { get; set; }
        public string Nomtm { get; set; } = null!;
        public int Idtargetpengobatan { get; set; }
        public string? Keterangan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
