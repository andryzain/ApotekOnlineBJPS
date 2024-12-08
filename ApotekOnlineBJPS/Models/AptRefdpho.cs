using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefdpho
    {
        public AptRefdpho()
        {
            AptDatobats = new HashSet<AptDatobat>();
        }

        [Key]
        public Guid AptRefdphoId { get; set; }
        public string Kdobat { get; set; } = null!;
        public string Kdprop { get; set; } = null!;
        public string? Jnsobt { get; set; }
        public string? Generik { get; set; }
        public string? Dagang { get; set; }
        public string? Pabrik { get; set; }
        public string? Obat { get; set; }
        public string? Kekuatan { get; set; }
        public string? Sediaan { get; set; }
        public decimal? Sedia { get; set; }
        public string? Satuan { get; set; }
        public decimal? Signa1 { get; set; }
        public decimal? Signa2 { get; set; }
        public double? Hdasar { get; set; }
        public short? Kdfaktor { get; set; }
        public string? Restriksi { get; set; }
        public string? Klsterapi { get; set; }
        public string? Subkls { get; set; }
        public string? Sub2kls { get; set; }
        public string? Kodegenerik { get; set; }
        public string? Kuat { get; set; }
        public string? Kdjnsobat { get; set; }
        public short? Hmax { get; set; }
        public short? Rmax { get; set; }
        public short? Lmax { get; set; }
        public short? Hdiff { get; set; }
        public DateTime? Tglmulai { get; set; }
        public DateTime? Tglakhir { get; set; }
        public string? Atccode { get; set; }
        public string? Kdekatalog { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Tgltayang { get; set; }

        public virtual ICollection<AptDatobat> AptDatobats { get; set; }
    }
}
