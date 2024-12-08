using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptMutasiStok
    {
        [Key]
        public Guid AptMutasiStokId { get; set; }
        public string Kdppk { get; set; } = null!;
        public string Kdobat { get; set; } = null!;
        public string Kdjnsmutasi { get; set; } = null!;
        public DateTime Tglmutasi { get; set; }
        public decimal? Jmlobat { get; set; }
        public string? Keterangan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
