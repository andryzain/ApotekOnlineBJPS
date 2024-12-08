using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmReftindaklanjutpengobatan
    {
        [Key]
        public Guid AptMtmReftindaklanjutpengobatanId { get; set; }
        public long Idtindaklanjutpengobatan { get; set; }
        public string? Nmtindaklanjutpengobatan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
