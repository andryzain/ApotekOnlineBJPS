using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatkunjungan
    {
        public string NoKunjungan { get; set; } = null!;
        public DateTime? TglKunjungan { get; set; }
        public string? Refasalkunjungan { get; set; }
        public string? PpkKunjungan { get; set; }
        public string? Nokapst { get; set; }
        public string? Pisapst { get; set; }
        public string? Kdpoli { get; set; }
        public string? KdProgprolanis { get; set; }
        public string? Keluhan { get; set; }
        public string? KdDiagnosa { get; set; }
        public string? Kdsadar { get; set; }
        public int? Sistole { get; set; }
        public int? Diastole { get; set; }
        public decimal? Beratbadan { get; set; }
        public int? Tinggibadan { get; set; }
        public decimal? RespRate { get; set; }
        public decimal? HeartRate { get; set; }
        public string? Catatankhusus { get; set; }
        public string? Pemeriksaanlain { get; set; }
        public bool? Rujuklanjutf { get; set; }
        public string? PpkRujuk { get; set; }
        public string? PoliRujuk { get; set; }
        public string? PpkAsalrujuk { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Status { get; set; }
        public string? Kdtkp { get; set; }
        public string? Kdstatuspulang { get; set; }
        public DateTime? Tglpulang { get; set; }
        public string? PpkPst { get; set; }
        public string? Kdjnspst { get; set; }
        public bool? Rujukbalikf { get; set; }
        public string? KdDiagnosa2 { get; set; }
        public string? KdDiagnosa3 { get; set; }
        public decimal? Biaya { get; set; }
        public long? PrbId { get; set; }
        public string? Kddokter { get; set; }
        public string? PoliRujukinternal { get; set; }
        public string? KdKunjungan { get; set; }
        public string? Idsistem { get; set; }
        public string? Kdkc { get; set; }
        public bool? Dilayanirs { get; set; }
        public string? Kdtagih { get; set; }
    }
}
