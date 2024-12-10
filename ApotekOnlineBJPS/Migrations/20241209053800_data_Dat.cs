using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class data_Dat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DatNama",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DatNoPegawai",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DatPassword",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DatUserName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MasterDatLogin",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOPEG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdJnsUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdGrupUserApp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NmGrupUserApp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlagKantor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDDATI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMDATI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMKC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDPROP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMPROP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDKR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMKR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAktif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokasiID = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_MasterDatLogin", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterDatLogin",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "DatNama",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DatNoPegawai",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DatPassword",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DatUserName",
                table: "AspNetUsers");
        }
    }
}
