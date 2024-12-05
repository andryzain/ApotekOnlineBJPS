using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptDatkekosonganobatViewModel
    {
        public string Id { get; set; } = null!;
        public string Kdprop { get; set; } = null!;
        public string Kdppk { get; set; } = null!;
        public string Kdobat { get; set; } = null!;
        public string? Kdjnsinstansi { get; set; }
        public bool? Accountepurch { get; set; }
        public DateTime Tglkejadian { get; set; }
        public DateTime Tglsuratpemesanan { get; set; }
        public string Kdmetodepemesanan { get; set; } = null!;
        public int? Jmlobat { get; set; }
        public string? Kdpabrik { get; set; }
        public string? Namadistributor { get; set; }
        public string Kdalasankosong { get; set; } = null!;
        public string? Keterangan { get; set; }
        public short? Flag { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Luser { get; set; }

        public virtual AptRefalasankosongobatViewModel KdalasankosongNavigation { get; set; } = null!;
    }
}
