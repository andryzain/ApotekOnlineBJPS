namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptReffiltrasitkpViewModel
    {
        public string Idfiltrasi { get; set; } = null!;
        public string Kdtkp { get; set; } = null!;
        public bool? Flagaktif { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Luser { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
