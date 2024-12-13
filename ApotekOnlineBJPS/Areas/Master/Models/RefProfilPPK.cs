using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("RefProfilPPK", Schema = "dbo")]
    public class RefProfilPPK
    {
        [Key]
        public Guid RefProfilPPKId { get; set; }
        public string KDKC { get; set; }
        public string NMKC { get; set; }
        public string DATI2PPK { get; set; }
        public string KDPPK { get; set; }
        public string NMPPK { get; set; }
        public string JNSKAPPPK { get; set; }
        public string KEPEMILIKANPPK { get; set; }
        public string TYPEPPK { get; set; }
        public string JNSPPK { get; set; }
        public string NMJLNPPK { get; set; }
        public string RTPPK { get; set; }
        public string RWPPK { get; set; }
        public string KDPOSPPK { get; set; }
        public string KELPPK { get; set; }
        public string KECPPK { get; set; }
        public string NMDATI2PPK { get; set; }
        public string NMPROPPPK { get; set; }
        public string TELPPPK { get; set; }
        public string FAXPPK { get; set; }
        public DateTime TGLPKSPPK { get; set; }
        public DateTime TGLHBSPKSPPK { get; set; }
        public double BEDPPK { get; set; }
        public string KODPPK { get; set; }
        public bool VERTICALF { get; set; }
        public bool PROLANISF { get; set; }
        public bool FLAGAKTIF { get; set; }
        public string FLAGPKS { get; set; }
        public string FLAGCOB { get; set; }
        public string FLAGGRUP { get; set; }
        public string KDKEPEMILIKAN { get; set; }
        public string NMKEPEMILIKAN { get; set; }
        public string KDDATI2 { get; set; }
        public string NMDATI2 { get; set; }
        public string KDPROP { get; set; }
        public string NMPROP { get; set; }
        public string KDKR { get; set; }
        public string NMKR { get; set; }
        public bool FLAGFPELKEFARMASIANTAMBAHAN { get; set; }
    }
}
