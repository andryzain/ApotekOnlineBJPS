namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptRefjnspelsjpViewModel
    {
        public AptRefjnspelsjpViewModel()
        {
            AptDatsjps = new HashSet<AptDatsjpViewModel>();
        }

        public string Jnspelsjp { get; set; } = null!;
        public string Nmjnspelsjp { get; set; } = null!;
        public bool? Flagaktif { get; set; }

        public virtual ICollection<AptDatsjpViewModel> AptDatsjps { get; set; }
    }
}
