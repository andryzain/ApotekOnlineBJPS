using ApotekOnlineBJPS.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("MasterDatStock", Schema = "dbo")]
    public class DatStock : UserActivity
    {
        [Key]
        public Guid DATSTOCKID { get; set; }
        public string KDPPK { get; set; }
        public string KDOBAT { get; set; }
        public DateTime TGLMUT { get; set; }
        public double Stok { get; set; }
        public double STOKMINIM { get; set; }
    }
}
