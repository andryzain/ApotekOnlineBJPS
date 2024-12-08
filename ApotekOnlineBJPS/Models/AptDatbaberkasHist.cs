using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatbaberkasHist
    {
        [Key]
        public Guid AptDatbaberkasHistId { get; set; }
        public string Nopbk { get; set; } = null!;
        public short? Statuspb { get; set; }
        public bool? Istolak { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
    }
}
