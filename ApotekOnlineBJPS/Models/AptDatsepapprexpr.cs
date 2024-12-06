using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptDatsepapprexpr
    {
        [Key]
        public Guid AptDatsepapprexprId { get; set; }
        public string Nosep { get; set; } = null!;
        public string Kdppkpelsep { get; set; } = null!;
        public string Kdppkapotek { get; set; } = null!;
        public DateTime Tglplgsep { get; set; }
        public DateTime? Tglpengajuan { get; set; }
        public DateTime Tglappr { get; set; }
        public string Fuser { get; set; } = null!;
        public DateTime Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
        public short? Flag { get; set; }
    }
}
