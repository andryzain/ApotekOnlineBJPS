﻿using System;
using System.Collections.Generic;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefjnsfiltrasi
    {
        public AptRefjnsfiltrasi()
        {
            AptDatbafiltrasis = new HashSet<AptDatbafiltrasi>();
        }

        public string Idfiltrasi { get; set; } = null!;
        public string? Keterangan { get; set; }
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }

        public virtual ICollection<AptDatbafiltrasi> AptDatbafiltrasis { get; set; }
    }
}