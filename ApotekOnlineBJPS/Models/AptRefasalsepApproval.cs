using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptRefasalsepApproval
    {
        [Key]
        public Guid AptRefasalsepApprovalId { get; set; }
        public string Kdppk { get; set; } = null!;
        public string Ppkpelrsp { get; set; } = null!;
        public string Nosep { get; set; } = null!;
        public string? Jnspelsep { get; set; }
        public DateTime? Tglsep { get; set; }
        public string Nokapst { get; set; } = null!;
        public string? Nmpst { get; set; }
        public DateTime? Tglaju { get; set; }
        public string? Useridaju { get; set; }
        public DateTime? Tglappr { get; set; }
        public string? Useridappr { get; set; }
        public short? Flagappr { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
