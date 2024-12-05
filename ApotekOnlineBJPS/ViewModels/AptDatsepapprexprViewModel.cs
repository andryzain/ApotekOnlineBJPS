using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptDatsepapprexprViewModel
    {
        public string Nosep { get; set; } = null!;
        public string Kdppkpelsep { get; set; } = null!;
        public string Kdppkapotek { get; set; } = null!;
        public DateTime Tglplgsep { get; set; }
        public DateTime? Tglpengajuan { get; set; }
        public DateTime Tglappr { get; set; }
        public string Fuser { get; set; } = null!;
        public DateTime Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
        public short? Flag { get; set; }
    }
}
