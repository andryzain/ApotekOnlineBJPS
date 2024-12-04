using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefstatuspb
    {
        public AptRefstatuspb()
        {
            AptDatbaberkas = new HashSet<AptDatbaberka>();
            AptDatbapengajuanklaims = new HashSet<AptDatbapengajuanklaim>();
        }

        public short Statuspb { get; set; }
        public string? Nmstatuspb { get; set; }
        public string? Nmproses { get; set; }
        public string? Keterangan { get; set; }

        public virtual ICollection<AptDatbaberka> AptDatbaberkas { get; set; }
        public virtual ICollection<AptDatbapengajuanklaim> AptDatbapengajuanklaims { get; set; }
    }
}
