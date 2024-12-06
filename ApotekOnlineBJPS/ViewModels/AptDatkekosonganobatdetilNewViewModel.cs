
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptDatkekosonganobatdetilNewViewModel
    {
        public int Id { get; set; }
        public string Kdgenerikobat { get; set; } = null!;
        public string? Nmgenerikobat { get; set; }
        public int Periode { get; set; }
        public string? Jnsobat { get; set; }
        public string? Sediaan { get; set; }
        public string? Kekuatan { get; set; }
        public string? Nmpatendagangobat { get; set; }
        public string Kdindustrifarmasi { get; set; } = null!;
        public string? Industrifarmasi { get; set; }
        public string? Industrifarmasilain { get; set; }
        public string Kddistributorfarmasi { get; set; } = null!;
        public string? Nmdistributor { get; set; }
        public string? Nmdistributorlain { get; set; }
        public short? Flag { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Luser { get; set; }

        public virtual AptDatkekosonganobatNewViewModel IdNavigation { get; set; } = null!;
    }
}
