using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class PendataanResepMasuk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterPendataanResepMasuk",
                schema: "dbo",
                columns: table => new
                {
                    DatPendataanResepMasukId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_MasterPendataanResepMasuk", x => x.DatPendataanResepMasukId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterPendataanResepMasuk",
                schema: "dbo");
        }
    }
}
