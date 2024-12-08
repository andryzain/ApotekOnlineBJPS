using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterPendataanPRBMTM",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterPendataanResepMasuk",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterResepMasuk",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "MasterDatDokter",
                schema: "dbo",
                columns: table => new
                {
                    DATDOKTERID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KDPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdDokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmDokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdSpesialist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmSpesialist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlagAktif = table.Column<bool>(type: "bit", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatDokter", x => x.DATDOKTERID);
                });

            migrationBuilder.CreateTable(
                name: "MasterDatObat",
                schema: "dbo",
                columns: table => new
                {
                    DATOBATID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOSJP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NORESEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JNSROBT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDOBT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JMLOBT = table.Column<double>(type: "float", nullable: false),
                    SIGNA1OBT = table.Column<double>(type: "float", nullable: false),
                    SIGNA2OBT = table.Column<double>(type: "float", nullable: false),
                    JHO = table.Column<double>(type: "float", nullable: false),
                    SERVICEOBT = table.Column<double>(type: "float", nullable: false),
                    HRGTAGOBT = table.Column<double>(type: "float", nullable: false),
                    HRGVEROBT = table.Column<double>(type: "float", nullable: false),
                    HRGSTJOBT = table.Column<double>(type: "float", nullable: false),
                    FLAGCOBT = table.Column<bool>(type: "bit", nullable: false),
                    FLAGVOBT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ALASANOBT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDOBTVER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JMLOBTVER = table.Column<double>(type: "float", nullable: false),
                    SIGNA1VER = table.Column<double>(type: "float", nullable: false),
                    SIGNA2VER = table.Column<double>(type: "float", nullable: false),
                    JHOVER = table.Column<double>(type: "float", nullable: false),
                    PERMINTAAN = table.Column<double>(type: "float", nullable: false),
                    KEKUATAN = table.Column<double>(type: "float", nullable: false),
                    PERMINTAANVER = table.Column<double>(type: "float", nullable: false),
                    KEKUATANVER = table.Column<double>(type: "float", nullable: false),
                    NOKONF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SEDIANDPHO = table.Column<double>(type: "float", nullable: false),
                    HDasarNDpho = table.Column<double>(type: "float", nullable: false),
                    FaktorNDpho = table.Column<double>(type: "float", nullable: false),
                    NMObatNDpho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaktorVer = table.Column<double>(type: "float", nullable: false),
                    HDasarVer = table.Column<double>(type: "float", nullable: false),
                    ServiceVer = table.Column<double>(type: "float", nullable: false),
                    HDasar = table.Column<double>(type: "float", nullable: false),
                    Faktor = table.Column<double>(type: "float", nullable: false),
                    JMLOBTR = table.Column<double>(type: "float", nullable: false),
                    JMLOBTRVER = table.Column<double>(type: "float", nullable: false),
                    FlagTanggung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatKhsObt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatKhsObtVer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatObat", x => x.DATOBATID);
                });

            migrationBuilder.CreateTable(
                name: "MasterDatResep",
                schema: "dbo",
                columns: table => new
                {
                    DATRESEPID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOSJP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NORESEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TKPRSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POLIRSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPFRSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLPELRSP = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TGLRSP = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    BYTAGRSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BYVERRSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BYSTJRSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGTIRSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NORESEPAPT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdDokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmDokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlagKirim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglKirim = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TGLVER = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Iterasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountIterasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatResep", x => x.DATRESEPID);
                });

            migrationBuilder.CreateTable(
                name: "MasterDatSepPeserta",
                schema: "dbo",
                columns: table => new
                {
                    DATSEPPESERTAID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOKAPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PSNOKALAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOKA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JKPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLLHRPST = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOKTP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KKNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDHUBKEL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PISAPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDSTAWIN = table.Column<int>(type: "int", nullable: false),
                    NMSTAWIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDSTATUSPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KETSTATUSPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPKPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOHP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKANTOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TMT = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TAT = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FLAGTANGGUNGAN = table.Column<int>(type: "int", nullable: false),
                    KDJNSPESERTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KETJNSPESERTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDJNSPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ALAMAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDGOLDARAH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPPKPSTGIGI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPPKPSTGIGI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDJNSKPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMJNSKPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPKS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPKS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIPBARU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIPLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDGOL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KETGOLRU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKELASI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKELAS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KETKELAS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLCETAK = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    KDASURANSI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOASUR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TMTASUR = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TATASUR = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    NMASURANSI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DINSOS = table.Column<int>(type: "int", nullable: false),
                    NAMABAYI = table.Column<int>(type: "int", nullable: false),
                    TMTPREMI = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PREMI = table.Column<double>(type: "float", nullable: false),
                    TMTPPK = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FLAGKOL = table.Column<int>(type: "int", nullable: false),
                    SKTM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLSTATUS = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FIRSTAKTIF = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatSepPeserta", x => x.DATSEPPESERTAID);
                });

            migrationBuilder.CreateTable(
                name: "MasterDatStock",
                schema: "dbo",
                columns: table => new
                {
                    DATSTOCKID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KDPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDOBAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLMUT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stok = table.Column<double>(type: "float", nullable: false),
                    STOKMINIM = table.Column<double>(type: "float", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatStock", x => x.DATSTOCKID);
                });

            migrationBuilder.CreateTable(
                name: "MasterResepPRB",
                schema: "dbo",
                columns: table => new
                {
                    ResepPRBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KdGenerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmGenerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signa1 = table.Column<int>(type: "int", nullable: false),
                    Signa2 = table.Column<int>(type: "int", nullable: false),
                    Signa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JmlObat = table.Column<int>(type: "int", nullable: false),
                    TglResep = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterResepPRB", x => x.ResepPRBId);
                });

            migrationBuilder.CreateTable(
                name: "MasterDatPRBMTMPCare",
                schema: "dbo",
                columns: table => new
                {
                    DatPRBMTMPCareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoKunjungan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResepMasukId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KdRiwAlergiObat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KetRiwAlergiObat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdRiwEfekObat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KetRiwEfekObat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdRiwMerokok = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KetRiwMerokok = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdRiwObatTambahan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KetRiwObatTambahan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerbaikanGejala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerbaikanLab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PenurunanRisiko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPPK_APOTIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatPRBMTMPCare", x => x.DatPRBMTMPCareId);
                    table.ForeignKey(
                        name: "FK_MasterDatPRBMTMPCare_MasterDatResep_ResepMasukId",
                        column: x => x.ResepMasukId,
                        principalSchema: "dbo",
                        principalTable: "MasterDatResep",
                        principalColumn: "DATRESEPID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterDatPRBMTMPCare_ResepMasukId",
                schema: "dbo",
                table: "MasterDatPRBMTMPCare",
                column: "ResepMasukId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterDatDokter",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterDatObat",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterDatPRBMTMPCare",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterDatSepPeserta",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterDatStock",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterResepPRB",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterDatResep",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "MasterPendataanPRBMTM",
                schema: "dbo",
                columns: table => new
                {
                    PendataanPrbMtmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BeratBadan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Diagnosa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diastole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dpjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Efektivitas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FktpTerdaftar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FktrlPerujukBalik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indikasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    JenisKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoHandphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKa_Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKunjunganPcare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatAlergiObat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatEso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatMerokok = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatPenggunaanObatTambahan_Alternatif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sistole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglInput = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    VitalSign = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPendataanPRBMTM", x => x.PendataanPrbMtmId);
                });

            migrationBuilder.CreateTable(
                name: "MasterPendataanResepMasuk",
                schema: "dbo",
                columns: table => new
                {
                    PendataanResepMasukId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BadanUsaha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Diagnosa_awal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaskesAsalResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Iterasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsPst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmPeserta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKartu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pisat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPelayanan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPulang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TkPlyn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPendataanResepMasuk", x => x.PendataanResepMasukId);
                });

            migrationBuilder.CreateTable(
                name: "MasterResepMasuk",
                schema: "dbo",
                columns: table => new
                {
                    ResepMasukId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BadanUsaha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeleteDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Diagnosa_awal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaskesAsalResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    JnsKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsPst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmPeserta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKartu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pisat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglEntry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPelayanan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPulang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TkPlyn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterResepMasuk", x => x.ResepMasukId);
                });
        }
    }
}
