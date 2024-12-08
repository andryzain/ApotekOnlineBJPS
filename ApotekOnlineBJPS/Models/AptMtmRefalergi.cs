using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMtmRefalergi
    {
        [Key]
        public Guid AptMtmRefalergiId { get; set; }
        public string Idrefalergi { get; set; } = null!;
        public string Nmalergi { get; set; } = null!;
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
