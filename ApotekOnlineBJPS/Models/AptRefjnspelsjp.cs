using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptRefjnspelsjp
    {
        public AptRefjnspelsjp()
        {
            AptDatsjps = new HashSet<AptDatsjp>();
        }

        [Key]
        public Guid AptRefjnspelsjpId { get; set; }
        public string Jnspelsjp { get; set; } = null!;
        public string Nmjnspelsjp { get; set; } = null!;
        public bool? Flagaktif { get; set; }

        public virtual ICollection<AptDatsjp> AptDatsjps { get; set; }
    }
}
