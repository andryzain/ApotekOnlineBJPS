using ApotekOnlineBJPS.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("MasterResepPRB", Schema = "dbo")]
    public class ResepPRB : UserActivity
    {
        [Key]
        public Guid ResepPRBId { get; set; } = Guid.NewGuid();
        public string KdGenerik { get; set; }
        public string NmGenerik { get; set; }
        public int Signa1 { get; set; }
        public int Signa2 { get; set; }
        public string Signa { get; set; }
        public int JmlObat { get; set; }
        public DateTimeOffset TglResep { get; set; }        
    }
}
