using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptLogdownload
    {
        [Key]
        public Guid AptLogdownloadId { get; set; }
        public string? Userid { get; set; }
        public DateTime? Waktu { get; set; }
        public string? Controller { get; set; }
        public string? Metode { get; set; }
        public string? Ip { get; set; }
        public string? Keterangan { get; set; }
    }
}
