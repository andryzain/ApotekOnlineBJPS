namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMtmDatketercapaiantargetViewModel
    {
        public string Nomtm { get; set; } = null!;
        public int? Idtargetpengobatan { get; set; }
        public int? Idketercapaiantarget { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
