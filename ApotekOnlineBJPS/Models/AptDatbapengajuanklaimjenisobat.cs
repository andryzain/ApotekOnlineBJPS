using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatbapengajuanklaimjenisobat
    {
        [Key]
        public Guid AptDatbapengajuanklaimjenisobatId { get; set; }
        public string Nopbk { get; set; } = null!;
        public string Kdjnsobat { get; set; } = null!;
        public int? Jmlrsptag { get; set; }
        public int? Jmlrspver { get; set; }
        public string? Keterangantag { get; set; }
        public string? Keteranganver { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Luser { get; set; }

        public virtual AptDatbapengajuanklaim NopbkNavigation { get; set; } = null!;
    }
}
