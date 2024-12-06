namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMtmDatmtmViewModel
    {
        public AptMtmDatmtmViewModel()
        {
            AptMtmDatgroupmasalahs = new HashSet<AptMtmDatgroupmasalahViewModel>();
            AptMtmDatmasalahs = new HashSet<AptMtmDatmasalahViewModel>();
        }

        public string Nomtm { get; set; } = null!;
        public DateTime? Tglmtm { get; set; }
        public string Nosjp { get; set; } = null!;
        public string? Nohp { get; set; }
        public int Flagmtm { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual ICollection<AptMtmDatgroupmasalahViewModel> AptMtmDatgroupmasalahs { get; set; }
        public virtual ICollection<AptMtmDatmasalahViewModel> AptMtmDatmasalahs { get; set; }
    }
}
