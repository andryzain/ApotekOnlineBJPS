using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class sepdanref : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterDatSep",
                schema: "dbo",
                columns: table => new
                {
                    DatSepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JNSPELSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLSEP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NOKAPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JKPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLLHRPST = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PISAPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDJNSPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKLSPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPKASALPST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDASU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MRPSTSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKLSRWT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    REFASALSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLRJKAWALSEP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NORJKAWALSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPKRJKAWALSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIAGPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POLITUJSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CATKHSSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGRUJUKAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGPRSKLAIMSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPKPELSEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOCETAK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SINKRON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AKT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPENUNJANG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPENUNJANG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDDOKTER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMDOKTER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGPROSEDUR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OPSIKONSUL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGSPRI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDatSep", x => x.DatSepId);
                });

            migrationBuilder.CreateTable(
                name: "RefProfilPPK",
                schema: "dbo",
                columns: table => new
                {
                    RefProfilPPKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KDKC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMKC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATI2PPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JNSKAPPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KEPEMILIKANPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TYPEPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JNSPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMJLNPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RTPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RWPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPOSPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KELPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KECPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMDATI2PPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPROPPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELPPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FAXPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGLPKSPPK = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TGLHBSPKSPPK = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BEDPPK = table.Column<double>(type: "float", nullable: false),
                    KODPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VERTICALF = table.Column<bool>(type: "bit", nullable: false),
                    PROLANISF = table.Column<bool>(type: "bit", nullable: false),
                    FLAGAKTIF = table.Column<bool>(type: "bit", nullable: false),
                    FLAGPKS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGCOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGGRUP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKEPEMILIKAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMKEPEMILIKAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDDATI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMDATI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPROP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPROP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMKR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FLAGFPELKEFARMASIANTAMBAHAN = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefProfilPPK", x => x.RefProfilPPKId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterDatSep",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MasterPendataanResepMasuk",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RefProfilPPK",
                schema: "dbo");
        }
    }
}
