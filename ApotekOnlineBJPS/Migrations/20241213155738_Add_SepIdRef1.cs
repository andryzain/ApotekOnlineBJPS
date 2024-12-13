using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class Add_SepIdRef1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatResepMasukId",
                schema: "dbo",
                table: "MasterPendataanResepMasuk");

            migrationBuilder.AddColumn<Guid>(
                name: "RefProfilPPKId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_MasterDatSepPeserta_RefProfilPPKId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                column: "RefProfilPPKId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDatSepPeserta_RefProfilPPK_RefProfilPPKId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                column: "RefProfilPPKId",
                principalSchema: "dbo",
                principalTable: "RefProfilPPK",
                principalColumn: "RefProfilPPKId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDatSepPeserta_RefProfilPPK_RefProfilPPKId",
                schema: "dbo",
                table: "MasterDatSepPeserta");

            migrationBuilder.DropTable(
                name: "RefProfilPPK",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_MasterDatSepPeserta_RefProfilPPKId",
                schema: "dbo",
                table: "MasterDatSepPeserta");

            migrationBuilder.DropColumn(
                name: "RefProfilPPKId",
                schema: "dbo",
                table: "MasterDatSepPeserta");

            migrationBuilder.AddColumn<Guid>(
                name: "DatResepMasukId",
                schema: "dbo",
                table: "MasterPendataanResepMasuk",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
