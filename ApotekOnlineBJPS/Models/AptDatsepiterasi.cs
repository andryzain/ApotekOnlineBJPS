using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatsepiterasi
    {
        public string Nosjp { get; set; } = null!;
        public string Refasalsjp { get; set; } = null!;
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public int Iterasi { get; set; }
    }
}
