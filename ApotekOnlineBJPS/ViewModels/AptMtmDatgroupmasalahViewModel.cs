namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMtmDatgroupmasalahViewModel
    {
        public string Nomtm { get; set; } = null!;
        public string Idgroupmasalah { get; set; } = null!;
        public string? Keterangan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptMtmDatmtmViewModel NomtmNavigation { get; set; } = null!;
    }
}
