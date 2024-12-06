using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotikOnlineBJPS.Models
{
    public partial class AptDatbafiltrasidetail
    {
        [Key]
        public Guid AptDatbafiltrasidetailId { get; set; }
        public string Nopbk { get; set; } = null!;
        public string Idfiltrasi { get; set; } = null!;
        public string Nosjp { get; set; } = null!;
        public string Noresep { get; set; } = null!;
    }
}
