using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptMtmReftargetpengobatan
    {
        [Key]
        public Guid AptMtmReftargetpengobatanId { get; set; }
        public long Idtargetpengobatan { get; set; }
        public string? Nmtargetpengobatan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
