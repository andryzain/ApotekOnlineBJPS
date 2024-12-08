using ApotekOnlineBJPS.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("MasterDatLogin", Schema = "dbo")]
    public class DatLogin : UserActivity
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Nama { get; set; }
        public string NOPEG { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string KdJnsUser { get; set; }
        /// <summary>
        /// 001:Petugas Entri, 002:Verifikator, 003:Kepala Bidang, 004:Kepala Cabang
        /// </summary>
        public string KdGrupUserApp { get; set; }
        public string NmGrupUserApp { get; set; }
        public string FlagKantor { get; set; }
        public string KDPPK { get; set; }
        public string NMPPK { get; set; }
        public string KDDATI2 { get; set; }
        public string NMDATI2 { get; set; }
        public string KDKC { get; set; }
        public string NMKC { get; set; }
        public string KDPROP { get; set; }
        public string NMPROP { get; set; }
        public string KDKR { get; set; }
        public string NMKR { get; set; }
        public string Email { get; set; }
        public string IsAdmin { get; set; }
        public string IsAktif { get; set; }
        public string LokasiID { get; set; }
    }
}
