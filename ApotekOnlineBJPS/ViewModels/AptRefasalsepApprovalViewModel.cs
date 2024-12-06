namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptRefasalsepApprovalViewModel
    {
        public string Kdppk { get; set; } = null!;
        public string Ppkpelrsp { get; set; } = null!;
        public string Nosep { get; set; } = null!;
        public string? Jnspelsep { get; set; }
        public DateOnly? Tglsep { get; set; }
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
