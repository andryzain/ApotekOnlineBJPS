using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatsepiterasi
    {
        [Key]
        public Guid AptDatsepiterasiId { get; set; }
        public string Nosjp { get; set; } = null!;
        public string Refasalsjp { get; set; } = null!;
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public int Iterasi { get; set; }
    }
}
