using ApotekOnlineBJPS.Models;
namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptLoguserViewModel
    {
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
