﻿namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptObatlkppViewModel
    {
        public string Idobat { get; set; } = null!;
        public string? Idfornas { get; set; }
        public string? Dagang { get; set; }
        public string? Pabrik { get; set; }
        public string? Kdjnsobat { get; set; }
        public string? Edisifornas { get; set; }
        public string? Edisilkpp { get; set; }
        public string Noproduklkpp { get; set; } = null!;
        public DateTime? Tmt { get; set; }
        public DateTime? Tat { get; set; }
        public DateTime? Fdate { get; set; }
        public string? Fuser { get; set; }
        public DateTime? Ldate { get; set; }
        public string? Luser { get; set; }
    }
}
