using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatbapengajuanklaimdetail
    {
        [Key]
        public Guid AptDatbapengajuanklaimdetailId { get; set; }
        public string Nopbk { get; set; } = null!;
        public string Nosjp { get; set; } = null!;
        public string Noresep { get; set; } = null!;
        public string? Refasalsjp { get; set; }
        public string Nokapst { get; set; } = null!;
        public string? Nmpst { get; set; }
        public DateTime? Tglrsp { get; set; }
        public decimal? Bytagsjp { get; set; }
        public decimal? Byversjp { get; set; }
        public decimal? Bystjsjp { get; set; }
        public string? Kdjnsobat { get; set; }
        public DateTime? Tglverpb { get; set; }
        public short? Statusver { get; set; }
        public string? Userver { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
        public bool Flaguserver { get; set; }

        public virtual AptDatbapengajuanklaim NopbkNavigation { get; set; } = null!;
        public virtual AptRefstatusverresep? StatusverNavigation { get; set; }
    }
}
