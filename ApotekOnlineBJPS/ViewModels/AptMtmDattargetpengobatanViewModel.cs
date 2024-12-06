namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMtmDattargetpengobatanViewModel
    {
        public string Nomtm { get; set; } = null!;
        public int Idtargetpengobatan { get; set; }
        public string? Keterangan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
