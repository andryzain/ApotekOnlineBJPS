using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatnofpk
    {
        public AptDatnofpk()
        {
            AptDatsjps = new HashSet<AptDatsjp>();
        }

        [Key]
        public Guid AptDatnofpkId { get; set; }
        public string Nofpk { get; set; } = null!;
        public DateTime Tglnofpk { get; set; }
        public string? Jnspstfpk { get; set; }
        public decimal? Jmlksfpk { get; set; }
        public decimal? Jmltfpk { get; set; }
        public decimal? Bytagfpk { get; set; }
        public decimal? Byverfpk { get; set; }
        public decimal? Bystjfpk { get; set; }
        public DateTime? Tglstjfpk { get; set; }
        public string? Iduserfpk { get; set; }
        public string? Nipstjfpk { get; set; }
        public string Ppkfpk { get; set; } = null!;
        public string? Nofpkrs { get; set; }
        public decimal? Bytagobtfpk { get; set; }
        public decimal? Byverobtfpk { get; set; }
        public decimal? Bystjobtfpk { get; set; }
        public string? Userfpk { get; set; }
        public DateTime? Tglkrmfpk { get; set; }
        public decimal? Jmlrcdkrm { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Nmpetugasapt { get; set; }
        public string? Nippetugasapt { get; set; }
        public string? Nmkepalaapt { get; set; }
        public string? Nipkepalaapt { get; set; }
        public string? Jabkepalaapt { get; set; }
        public string? Jnspelfpk { get; set; }
        public bool? Flagstjfpk { get; set; }
        public DateTime? Tglpengajuan { get; set; }
        public short? Statusfpk { get; set; }
        public string? Useridstjfpk { get; set; }
        public short? Bulanyan { get; set; }
        public short? Tahunyan { get; set; }
        public bool? Isba { get; set; }
        public string? Noba { get; set; }
        public DateTime? Tgljthtempo { get; set; }

        public virtual ICollection<AptDatsjp> AptDatsjps { get; set; }
    }
}
