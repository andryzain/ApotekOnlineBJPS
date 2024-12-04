using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptLogdownload
    {
        public string? Userid { get; set; }
        public DateTime? Waktu { get; set; }
        public string? Controller { get; set; }
        public string? Metode { get; set; }
        public string? Ip { get; set; }
        public string? Keterangan { get; set; }
    }
}
