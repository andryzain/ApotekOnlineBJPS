using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefsettingppk
    {
        public string Kdppk { get; set; } = null!;
        public string? Nmapoteker { get; set; }
        public string? Nmkepala { get; set; }
        public string? Jabkepala { get; set; }
        public string? Nipkepala { get; set; }
        public string? Siup { get; set; }
        public string? Alamat { get; set; }
        public string? Kota { get; set; }
        public string? Nmverifikator { get; set; }
        public string? Nppverifikator { get; set; }
        public string? Nmpetugasapt { get; set; }
        public string? Nippetugasapt { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Fuser { get; set; }
        public string? Luser { get; set; }
        public bool Checkstock { get; set; }
    }
}
