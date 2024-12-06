namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptDatsepiterasiViewModel
    {
        public string Nosjp { get; set; } = null!;
        public string Refasalsjp { get; set; } = null!;
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
        public int Iterasi { get; set; }
    }
}
