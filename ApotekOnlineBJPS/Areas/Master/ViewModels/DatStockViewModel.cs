using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Areas.MasterData.ViewModels
{
    public class DatStockViewModel
    {
        public string KDPPK { get; set; }
        public string KDOBAT { get; set; }
        public DateTime TGLMUT { get; set; }
        public double Stok { get; set; }
        public double STOKMINIM { get; set; }
    }
}
