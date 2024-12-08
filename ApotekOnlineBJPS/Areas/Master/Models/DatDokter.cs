using ApotekOnlineBJPS.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("MasterDatDokter", Schema = "dbo")]
    public class DatDokter : UserActivity
    {
        [Key]
        public Guid DATDOKTERID { get; set; }
        public string KDPPK { get; set; }
        public string NMPPK { get; set; }
        public string KdDokter { get; set; }
        public string NmDokter { get; set; }
        public string KdSpesialist { get; set; }
        public string NmSpesialist { get; set; }
        public bool FlagAktif { get; set; }
    }
}
