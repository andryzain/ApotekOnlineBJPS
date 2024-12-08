using ApotekOnlineBJPS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatbapengajuanklaim
    {
        public AptDatbapengajuanklaim()
        {
            AptDatbaberkas = new HashSet<AptDatbaberkas>();
            AptDatbapengajuanklaimdetails = new HashSet<AptDatbapengajuanklaimdetail>();
            AptDatbapengajuanklaimjenisobats = new HashSet<AptDatbapengajuanklaimjenisobat>();
        }

        [Key]
        public Guid AptDatbapengajuanklaimID { get; set; }
        public string Nopbk { get; set; } = null!;
        public DateTime Tglpb { get; set; }
        public string Kdkc { get; set; } = null!;
        public string Kdppk { get; set; } = null!;
        public string Kdtkp { get; set; } = null!;
        public DateTime? Tgllayanan { get; set; }
        public short? Bulanyan { get; set; }
        public short? Tahunyan { get; set; }
        public decimal? Totksberkas { get; set; }
        public decimal? Totbyberkas { get; set; }
        public string Nmpengaju { get; set; } = null!;
        public string? Nippengaju { get; set; }
        public string? Jabpengaju { get; set; }
        public string? Nmdirektur { get; set; }
        public string? Nipdirektur { get; set; }
        public string? Keterangan { get; set; }
        public short? Statuspb { get; set; }
        public string? Nofpk { get; set; }
        public short? Istolak { get; set; }
        public string Fuser { get; set; } = null!;
        public DateTime Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
        public short Flagumk { get; set; }

        public virtual AptRefstatuspb? StatuspbNavigation { get; set; }
        public virtual ICollection<AptDatbaberkas> AptDatbaberkas { get; set; }
        public virtual ICollection<AptDatbapengajuanklaimdetail> AptDatbapengajuanklaimdetails { get; set; }
        public virtual ICollection<AptDatbapengajuanklaimjenisobat> AptDatbapengajuanklaimjenisobats { get; set; }
    }
}
