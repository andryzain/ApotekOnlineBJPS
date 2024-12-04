using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmDatriwayatkesehatan
    {
        public string Nomtm { get; set; } = null!;
        public int Idalergiobat { get; set; }
        public int Idalergiefek { get; set; }
        public int Idalergirokok { get; set; }
        public int Idalergiobattambahan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
