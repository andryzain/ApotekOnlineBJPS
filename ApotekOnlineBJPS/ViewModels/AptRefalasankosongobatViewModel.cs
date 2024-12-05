using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptRefalasankosongobatViewModel
    {
        public AptRefalasankosongobatViewModel()
        {
            AptDatkekosonganobatNews = new HashSet<AptDatkekosonganobatNewViewModel>();
            AptDatkekosonganobats = new HashSet<AptDatkekosonganobatViewModel>();
        }

        public string Kdalasankosong { get; set; } = null!;
        public string? Nmalasankosong { get; set; }
        public bool? Flagaktif { get; set; }

        public virtual ICollection<AptDatkekosonganobatNewViewModel> AptDatkekosonganobatNews { get; set; }
        public virtual ICollection<AptDatkekosonganobatViewModel> AptDatkekosonganobats { get; set; }
    }
}
