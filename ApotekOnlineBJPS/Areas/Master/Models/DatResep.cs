using ApotekOnlineBJPS.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("MasterDatResep", Schema = "dbo")]
    public class DatResep : UserActivity
    {
        [Key]
        public Guid DATRESEPID { get; set; } = Guid.NewGuid();
        public string NOSJP { get; set; } = ""; // Input Pencarian
        public string NORESEP { get; set; } = ""; 
        public string TKPRSP { get; set; } = "";
        public string POLIRSP { get; set; } = "";
        public string UPFRSP { get; set; } = "";
        public DateTimeOffset TGLPELRSP { get; set; }
        public DateTimeOffset TGLRSP { get; set; }
        public string BYTAGRSP { get; set; } = "";
        public string BYVERRSP { get; set; } = "";
        public string BYSTJRSP { get; set; } = "";
        public string FLAGTIRSP { get; set; } = "";
        public string NORESEPAPT { get; set; } = "";
        public string KdDokter { get; set; } = "";
        public string NmDokter { get; set; } = "";
        public string Status { get; set; } = "";
        public string FlagKirim { get; set; } = "";
        public DateTimeOffset TglKirim { get; set; }
        public DateTimeOffset TGLVER { get; set; }
        public string Iterasi { get; set; } = "";
        public string CountIterasi { get; set; } = "";
    }
}
