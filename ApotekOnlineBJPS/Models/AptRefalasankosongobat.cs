using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefalasankosongobat
    {
        public AptRefalasankosongobat()
        {
            AptDatkekosonganobatNews = new HashSet<AptDatkekosonganobatNew>();
            AptDatkekosonganobats = new HashSet<AptDatkekosonganobat>();
        }

        public string Kdalasankosong { get; set; } = null!;
        public string? Nmalasankosong { get; set; }
        public bool? Flagaktif { get; set; }

        public virtual ICollection<AptDatkekosonganobatNew> AptDatkekosonganobatNews { get; set; }
        public virtual ICollection<AptDatkekosonganobat> AptDatkekosonganobats { get; set; }
    }
}
