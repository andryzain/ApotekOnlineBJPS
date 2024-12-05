using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptRefstatusverresepViewModel
    {
        public AptRefstatusverresepViewModel()
        {
            AptDatbapengajuanklaimdetails = new HashSet<AptDatbapengajuanklaimdetailViewModel>();
        }

        public short Statusver { get; set; }
        public string? Keterangan { get; set; }
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual ICollection<AptDatbapengajuanklaimdetailViewModel> AptDatbapengajuanklaimdetails { get; set; }
    }
}
