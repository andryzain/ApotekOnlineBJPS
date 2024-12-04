using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptHistupdDatresep
    {
        public string Nosjp { get; set; } = null!;
        public string Noresep { get; set; } = null!;
        public string Tkprsp { get; set; } = null!;
        public string? Polirsp { get; set; }
        public string? Upfrsp { get; set; }
        public DateTime? Tglpelrsp { get; set; }
        public DateTime? Tglrsp { get; set; }
        public double? Bytagrsp { get; set; }
        public double? Byverrsp { get; set; }
        public double? Bystjrsp { get; set; }
        public string? Flagtirsp { get; set; }
        public string? Noresepapt { get; set; }
        public string? Kddokter { get; set; }
        public string? Nmdokter { get; set; }
        public string? Status { get; set; }
        public bool? Flagkirim { get; set; }
        public DateTime? Tglkirim { get; set; }
        public DateTime? Tglver { get; set; }
        public string? Useridver { get; set; }
        public short? Statuspb { get; set; }
        public DateTime Fdatehist { get; set; }
    }
}
