using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class initializeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "MasterPendataanPRBMTM",
                schema: "dbo",
                columns: table => new
                {
                    PendataanPrbMtmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TglInput = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKunjunganPcare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoHandphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKa_Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FktpTerdaftar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FktrlPerujukBalik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JenisKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dpjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VitalSign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeratBadan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sistole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diastole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatAlergiObat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatEso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatMerokok = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiwayatPenggunaanObatTambahan_Alternatif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indikasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Efektivitas = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_MasterPendataanPRBMTM", x => x.PendataanPrbMtmId);
                });

            migrationBuilder.CreateTable(
                name: "MasterPendataanResepMasuk",
                schema: "dbo",
                columns: table => new
                {
                    PendataanResepMasukId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaskesAsalResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKartu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmPeserta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pisat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsPst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadanUsaha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPulang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TkPlyn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosa_awal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPelayanan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iterasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_MasterPendataanResepMasuk", x => x.PendataanResepMasukId);
                });

            migrationBuilder.CreateTable(
                name: "MasterResepMasuk",
                schema: "dbo",
                columns: table => new
                {
                    ResepMasukId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TglEntry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaskesAsalResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKartu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmPeserta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pisat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsPst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadanUsaha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPulang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TkPlyn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosa_awal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JnsResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglResep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglPelayanan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pokter = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_MasterResepMasuk", x => x.ResepMasukId);
                });

            migrationBuilder.CreateTable(
                name: "MasterUserActive",
                schema: "dbo",
                columns: table => new
                {
                    UserActiveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserActiveCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Handphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_MasterUserActive", x => x.UserActiveId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "MasterUserActive",
                schema: "dbo");
        }
    }
}
