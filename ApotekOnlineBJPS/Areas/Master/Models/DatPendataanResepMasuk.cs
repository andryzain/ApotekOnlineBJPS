﻿using ApotekOnlineBJPS.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("MasterPendataanResepMasuk", Schema = "dbo")]
    public class DatPendataanResepMasuk : UserActivity
    {
        [Key]
        public Guid DatPendataanResepMasukId { get; set; }
        public string NoSEP { get; set; } = ""; // Input Pencarian
        public string FaskesAsalResep { get; set; } = "";
        public string NoKartu { get; set; } = "";
        public string NmPeserta { get; set; } = "";
        public string JnsKelamin { get; set; } = "";
        public string TglLahir { get; set; } = "";
        public string Pisat { get; set; } = "";
        public string JnsPst { get; set; } = "";
        public string BadanUsaha { get; set; } = "";
        public string TglSEP { get; set; } = "";
        public string TglPulang { get; set; } = "";
        public string TkPlyn { get; set; } = "";
        public string Diagnosa_awal { get; set; } = "";
        public string Poli { get; set; } = "";
        public string JnsResep { get; set; } = "";
        public string NoResep { get; set; } = "";
        public string TglResep { get; set; } = "";
        public string TglPelayanan { get; set; } = "";
        public string Pokter { get; set; } = "";
        public string Iterasi { get; set; } = "";
    }
}
