namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptDatsjpViewModel
    {
        public AptDatsjpViewModel()
        {
            AptDatreseps = new HashSet<AptDatresepViewModel>();
        }

        public string? Nofpk { get; set; }
        public string Nosjp { get; set; } = null!;
        public DateTime? Tglsjp { get; set; }
        public string? Refasalsjp { get; set; }
        public string Jnspelsjp { get; set; } = null!;
        public string Nokapst { get; set; } = null!;
        public string? Pisapst { get; set; }
        public string? Kdjnspeserta { get; set; }
        public string? Kdpks { get; set; }
        public decimal? Mrpstsjp { get; set; }
        public DateTime? Tgldtgsjp { get; set; }
        public DateTime? Tglplgsjp { get; set; }
        public DateTime? Tglrjkawalsjp { get; set; }
        public string? Norjkawalsjp { get; set; }
        public string? Ppkrjkawalsjp { get; set; }
        public string? Diagppk { get; set; }
        public string? Politujsjp { get; set; }
        public string? Diagrs { get; set; }
        public DateTime? Tglversjp { get; set; }
        public decimal? Bytagsjp { get; set; }
        public decimal? Byversjp { get; set; }
        public decimal? Bystjsjp { get; set; }
        public decimal? Jmlkssjp { get; set; }
        public decimal? Jmltsjp { get; set; }
        public string? Catkhssjp { get; set; }
        public string? Flagakhirsjp { get; set; }
        public string? Flagentrysjp { get; set; }
        public string? Flagprsklaimsjp { get; set; }
        public string Idusersjp { get; set; } = null!;
        public string? Nipstjsjp { get; set; }
        public string Ppkpelsjp { get; set; } = null!;
        public string? Flaglpstsjp { get; set; }
        public bool? Flagpstrs { get; set; }
        public string? Flagrrwt { get; set; }
        public DateTime? Tglstjkasie { get; set; }
        public string? Nipstjkasie { get; set; }
        public DateTime? Tglstjrs { get; set; }
        public string? Namastjrs { get; set; }
        public decimal? Bytagobtsjp { get; set; }
        public decimal? Byverobtsjp { get; set; }
        public decimal? Bystjobtsjp { get; set; }
        public decimal? Nocetak { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public DateTime? Tstamp { get; set; }
        public string? Kdjnsobat { get; set; }
        public bool? Issepoffline { get; set; }
        public int? Flagasaldata { get; set; }
        public bool? Flagiter { get; set; }
        public bool? Flagasalrspkunjrs { get; set; }

        public virtual AptRefjnspelsjpViewModel JnspelsjpNavigation { get; set; } = null!;
        public virtual AptDatnofpkViewModel? NofpkNavigation { get; set; }
        public virtual ICollection<AptDatresepViewModel> AptDatreseps { get; set; }
    }
}
