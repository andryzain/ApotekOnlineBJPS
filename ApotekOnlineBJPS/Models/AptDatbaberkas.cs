using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptDatbaberkas
    {
        [Key]
        public Guid AptDatbaberkasId { get; set; }
        public string Nopbk { get; set; } = null!;
        public short Statuspb { get; set; }
        public string Nosurat { get; set; } = null!;
        public DateTime Tglentri { get; set; }
        public DateTime? Tglba { get; set; }
        public string? Noreff { get; set; }
        public DateTime? Tglselesai { get; set; }
        public DateTime? Tgljthtempo { get; set; }
        public string? Nmpetugas { get; set; }
        public string? Nippetugas { get; set; }
        public string? Nmdirektur { get; set; }
        public string? Nipdirektur { get; set; }
        public string? Keterangan { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
        public bool Isbaotomatis { get; set; }

        //public virtual AptDatbapengajuanklaim NopbkNavigation { get; set; } = null!;
        //public virtual AptRefstatuspb StatuspbNavigation { get; set; } = null!;
    }
}
