using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptDatbafiltrasiViewModel
    {
        public string Nopbk { get; set; } = null!;
        public string Idfiltrasi { get; set; } = null!;
        public DateTime Tglfiltrasi { get; set; }
        public int? Kasus { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual AptRefjnsfiltrasiViewModel IdfiltrasiNavigation { get; set; } = null!;
    }
}
