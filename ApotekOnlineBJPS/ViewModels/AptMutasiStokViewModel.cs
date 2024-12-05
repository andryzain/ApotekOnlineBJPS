using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptMutasiStokViewModel
    {
        public string Kdppk { get; set; } = null!;
        public string Kdobat { get; set; } = null!;
        public string Kdjnsmutasi { get; set; } = null!;
        public DateOnly Tglmutasi { get; set; }
        public decimal? Jmlobat { get; set; }
        public string? Keterangan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
