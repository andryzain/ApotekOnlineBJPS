namespace ApotekOnlineBJPS.Areas.Master.ViewModels
{
    public class ResepPRBViewModel
    {
        public string KdGenerik { get; set; }
        public string NmGenerik { get; set; }
        public int Signa1 { get; set; }
        public int Signa2 { get; set; }
        public string Signa { get; set; }
        public int JmlObat { get; set; }
        public DateTimeOffset TglResep { get; set; }
    }
}
