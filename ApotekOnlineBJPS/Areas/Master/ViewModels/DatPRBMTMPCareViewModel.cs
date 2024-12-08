namespace ApotekOnlineBJPS.Areas.Master.ViewModels
{
    public class DatPRBMTMPCareViewModel
    {
        public string NoKunjungan { get; set; } = "";
        public Guid? ResepMasukId { get; set; }
        public string ResepMasuk { get; set; }
        public string KdRiwAlergiObat { get; set; } = "";
        public string KetRiwAlergiObat { get; set; } = "";
        public string KdRiwEfekObat { get; set; } = "";
        public string KetRiwEfekObat { get; set; } = "";
        public string KdRiwMerokok { get; set; } = "";
        public string KetRiwMerokok { get; set; } = "";
        public string KdRiwObatTambahan { get; set; } = "";
        public string KetRiwObatTambahan { get; set; } = "";
        public string PerbaikanGejala { get; set; } = "";
        public string PerbaikanLab { get; set; } = "";
        public string PenurunanRisiko { get; set; } = "";
        public string KDPPK_APOTIK { get; set; } = "";
        public string FUser { get; set; } = "";
        public DateTimeOffset FDate { get; set; }
        public string LUser { get; set; } = "";
        public DateTimeOffset LDate { get; set; }
    }
}
