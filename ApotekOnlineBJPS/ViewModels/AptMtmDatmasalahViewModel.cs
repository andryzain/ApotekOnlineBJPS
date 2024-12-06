namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMtmDatmasalahViewModel
    {
        public string Nomtm { get; set; } = null!;
        public string Idmasalah { get; set; } = null!;
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptMtmRefmasalahViewModel IdmasalahNavigation { get; set; } = null!;
        public virtual AptMtmDatmtmViewModel NomtmNavigation { get; set; } = null!;
    }
}
