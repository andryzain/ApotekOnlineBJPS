using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Areas.MasterData.ViewModels
{
    public class DatDokterViewModel
    {
        public string KDPPK { get; set; }
        public string NMPPK { get; set; }
        public string KdDokter { get; set; }
        public string NmDokter { get; set; }
        public string KdSpesialist { get; set; }
        public string NmSpesialist { get; set; }
        public bool FlagAktif { get; set; }
    }
}
