using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptDatkekosonganobatNewViewModel
    {
        public int Id { get; set; }
        public string Kdprop { get; set; } = null!;
        public string Kdppk { get; set; } = null!;
        public string? Jnsapotek { get; set; }
        public bool? Accountepurch { get; set; }
        public DateTime Tglkejadian { get; set; }
        public DateTime Tglsuratpemesanan { get; set; }
        public string? Noidpemesanepurchasing { get; set; }
        public string Kdmetodepemesanan { get; set; } = null!;
        public string Kdalasankosong { get; set; } = null!;
        public bool Telahpesantptdkadakonfirm { get; set; }
        public bool Sudahadaevidenfarmasi { get; set; }
        public string? Ketalasankekosonganobat { get; set; }
        public string? Pathevidenkendala { get; set; }
        public string? Tindaklanjut { get; set; }
        public bool? Penyampaiankekemkeslkpp { get; set; }
        public string? Pathevidenlaporan { get; set; }
        public string? Keterangan { get; set; }
        public short? Flag { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Luser { get; set; }

        public virtual AptRefalasankosongobatViewModel KdalasankosongNavigation { get; set; } = null!;
    }
}
