using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptRefstatusverresep
    {
        public AptRefstatusverresep()
        {
            AptDatbapengajuanklaimdetails = new HashSet<AptDatbapengajuanklaimdetail>();
        }

        [Key]
        public Guid AptRefstatusverresepId { get; set; }
        public short Statusver { get; set; }
        public string? Keterangan { get; set; }
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual ICollection<AptDatbapengajuanklaimdetail> AptDatbapengajuanklaimdetails { get; set; }
    }
}
