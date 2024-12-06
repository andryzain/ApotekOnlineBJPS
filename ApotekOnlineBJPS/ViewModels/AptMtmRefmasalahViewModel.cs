namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMtmRefmasalahViewModel
    {
        public AptMtmRefmasalahViewModel()
        {
            AptMtmDatmasalahs = new HashSet<AptMtmDatmasalahViewModel>();
        }

        public string Idgroupmasalah { get; set; } = null!;
        public string Idmasalah { get; set; } = null!;
        public string Nmmasalah { get; set; } = null!;
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptMtmRefgroupmasalahViewModel IdgroupmasalahNavigation { get; set; } = null!;
        public virtual ICollection<AptMtmDatmasalahViewModel> AptMtmDatmasalahs { get; set; }
    }
}
