using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptRefspesialistdokter
    {
        [Key]
        public Guid AptRefspesialistdokterId { get; set; }
        public string Kdspesialist { get; set; } = null!;
        public string? Nmspesialist { get; set; }
    }
}
