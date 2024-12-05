using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptHistupdDatobatViewModel
    {
        public string Nosjp { get; set; } = null!;
        public string Noresep { get; set; } = null!;
        public string Jnsrobt { get; set; } = null!;
        public string Kdobt { get; set; } = null!;
        public decimal? Jmlobt { get; set; }
        public decimal? Signa1obt { get; set; }
        public decimal? Signa2obt { get; set; }
        public decimal? Jho { get; set; }
        public decimal? Serviceobt { get; set; }
        public double? Hrgtagobt { get; set; }
        public double? Hrgverobt { get; set; }
        public double? Hrgstjobt { get; set; }
        public bool? Flagcobt { get; set; }
        public string? Flagvobt { get; set; }
        public string? Alasanobt { get; set; }
        public string? Kdobtver { get; set; }
        public decimal? Jmlobtver { get; set; }
        public decimal? Signa1ver { get; set; }
        public decimal? Signa2ver { get; set; }
        public decimal? Jhover { get; set; }
        public decimal? Permintaan { get; set; }
        public decimal? Kekuatan { get; set; }
        public decimal? Permintaanver { get; set; }
        public decimal? Kekuatanver { get; set; }
        public string? Nokonf { get; set; }
        public decimal? Sediandpho { get; set; }
        public decimal? Hdasarndpho { get; set; }
        public decimal? Faktorndpho { get; set; }
        public string? Nmobatndpho { get; set; }
        public decimal? Faktorver { get; set; }
        public decimal? Hdasarver { get; set; }
        public decimal? Servicever { get; set; }
        public decimal? Hdasar { get; set; }
        public decimal? Faktor { get; set; }
        public decimal? Jmlobtr { get; set; }
        public decimal? Jmlobtrver { get; set; }
        public string? Flagtanggung { get; set; }
        public string? Catkhsobt { get; set; }
        public string? Catkhsobtver { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime Fdatehist { get; set; }
    }
}
