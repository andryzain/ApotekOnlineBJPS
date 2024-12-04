using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmReftindaklanjutpengobatan
    {
        public long Idtindaklanjutpengobatan { get; set; }
        public string? Nmtindaklanjutpengobatan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
