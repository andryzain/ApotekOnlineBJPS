using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApotekOnlineBJPS.Models
{
    public partial class AptLoguser
    {
        [Key]
        public Guid AptLoguserId { get; set; }
        public long Userid { get; set; }
        public string? Username { get; set; }
        public string? Clientip { get; set; }
        public string? Hostname { get; set; }
        public DateTime? Lastlogin { get; set; }
        public DateTime? Lastlogout { get; set; }
        public DateTime? Lastactivity { get; set; }
        public bool? Isactive { get; set; }
    }
}
