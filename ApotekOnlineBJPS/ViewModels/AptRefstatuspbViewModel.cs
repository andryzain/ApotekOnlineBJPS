namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptRefstatuspbViewModel
    {
        public AptRefstatuspbViewModel()
        {
            AptDatbaberkas = new HashSet<AptDatbaberkasViewModel>();
            AptDatbapengajuanklaims = new HashSet<AptDatbapengajuanklaimViewModel>();
        }

        public short Statuspb { get; set; }
        public string? Nmstatuspb { get; set; }
        public string? Nmproses { get; set; }
        public string? Keterangan { get; set; }

        public virtual ICollection<AptDatbaberkasViewModel> AptDatbaberkas { get; set; }
        public virtual ICollection<AptDatbapengajuanklaimViewModel> AptDatbapengajuanklaims { get; set; }
    }
}
