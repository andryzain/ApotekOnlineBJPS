using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefjnspelsjp
    {
        public AptRefjnspelsjp()
        {
            AptDatsjps = new HashSet<AptDatsjp>();
        }

        public string Jnspelsjp { get; set; } = null!;
        public string Nmjnspelsjp { get; set; } = null!;
        public bool? Flagaktif { get; set; }

        public virtual ICollection<AptDatsjp> AptDatsjps { get; set; }
    }
}
