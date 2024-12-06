namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMtmRefgroupmasalahViewModel
    {
        public AptMtmRefgroupmasalahViewModel()
        {
            AptMtmDatobats = new HashSet<AptMtmDatobatViewModel>();
            AptMtmRefmasalahs = new HashSet<AptMtmRefmasalahViewModel>();
        }

        public string Idgroupmasalah { get; set; } = null!;
        public string? Nmgroupmasalah { get; set; }
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual ICollection<AptMtmDatobatViewModel> AptMtmDatobats { get; set; }
        public virtual ICollection<AptMtmRefmasalahViewModel> AptMtmRefmasalahs { get; set; }
    }
}
