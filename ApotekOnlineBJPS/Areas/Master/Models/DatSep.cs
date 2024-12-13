using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApotekOnlineBJPS.Areas.Master.Models
{
    [Table("MasterDatSep", Schema = "dbo")]
    public class DatSep
    {
        [Key]
        public Guid DatSepId { get; set; }
        public string NOSEP { get; set; } // Nomor SEP
        public string JNSPELSEP { get; set; } // Jenis Pelayanan SEP
        public DateTime TGLSEP { get; set; } // Tanggal SEP
        public string NOKAPST { get; set; } // Nomor Kartu Pasien
        public string NMPST { get; set; } // Nama Pasien
        public string JKPST { get; set; } // Jenis Kelamin Pasien
        public DateTime TGLLHRPST { get; set; } // Tanggal Lahir Pasien
        public string PISAPST { get; set; } // PISA Pasien
        public string KDJNSPST { get; set; } // Kode Jenis Pasien
        public string KDKLSPST { get; set; } // Kode Kelas Pasien
        public string PPKASALPST { get; set; } // Kode PPK Asal Pasien
        public string KDASU { get; set; } // Kode Asuransi
        public string MRPSTSEP { get; set; } // MR Pasien SEP
        public string KDKLSRWT { get; set; } // Kode Kelas Rawat
        public string REFASALSEP { get; set; } // Referensi Asal SEP
        public DateTime TGLRJKAWALSEP { get; set; } // Tanggal Rujukan Awal SEP
        public string NORJKAWALSEP { get; set; } // Nomor Rujukan Awal SEP
        public string PPKRJKAWALSEP { get; set; } // PPK Rujukan Awal SEP
        public string DIAGPPK { get; set; } // Diagnosis PPK
        public string POLITUJSEP { get; set; } // Poliklinik Tujuan SEP
        public string CATKHSSEP { get; set; } // Catatan KHS SEP
        public string FLAGRUJUKAN { get; set; } // Flag Rujukan
        public string FLAGPRSKLAIMSEP { get; set; } // Flag Proses Klaim SEP
        public string PPKPELSEP { get; set; } // PPK Pelayanan SEP
        public string NOCETAK { get; set; } // Nomor Cetak SEP
        public string SINKRON { get; set; } // Status Sinkronisasi
        public string AKT { get; set; } // Aktivasi SEP
        public string FP { get; set; } // FP SEP
        public string FUser { get; set; } // User untuk field F
        public string LUser { get; set; } // User untuk field L
        public DateTime FDate { get; set; } // Tanggal untuk field F
        public DateTime LDate { get; set; } // Tanggal untuk field L
        public string Flag { get; set; } // Flag status SEP
        public string KDPENUNJANG { get; set; } // Kode Penunjang
        public string NMPENUNJANG { get; set; } // Nama Penunjang
        public string KDDOKTER { get; set; } // Kode Dokter
        public string NMDOKTER { get; set; } // Nama Dokter
        public string FLAGPROSEDUR { get; set; } // Flag Prosedur SEP
        public string OPSIKONSUL { get; set; } // Opsi Konsultasi SEP
        public string FLAGSPRI { get; set; } // Flag SPri SEP

    }
}
