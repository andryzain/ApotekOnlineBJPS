﻿namespace ApotekOnlineBJPS.ViewModels
{
    public partial class AptRefharitanggunganViewModel
    {
        public string Kdppk { get; set; } = null!;
        public short? Hprb { get; set; }
        public short? Hkronis { get; set; }
        public short? Hkronisrs { get; set; }
        public short? Hkemo { get; set; }
        public DateTime Tglmulai { get; set; }
        public DateTime? Tglakhir { get; set; }
        public string? Fuser { get; set; }
        public string? Luser { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
