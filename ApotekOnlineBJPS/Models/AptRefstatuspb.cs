using ApotekOnlineBJPS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefstatuspb
    {
        public AptRefstatuspb()
        {
            AptDatbaberkas = new HashSet<AptDatbaberkas>();
            AptDatbapengajuanklaims = new HashSet<AptDatbapengajuanklaim>();
        }

        [Key]
        public Guid AptRefstatuspbId { get; set; }
        public short Statuspb { get; set; }
        public string? Nmstatuspb { get; set; }
        public string? Nmproses { get; set; }
        public string? Keterangan { get; set; }

        public virtual ICollection<AptDatbaberkas> AptDatbaberkas { get; set; }
        public virtual ICollection<AptDatbapengajuanklaim> AptDatbapengajuanklaims { get; set; }
    }
}
