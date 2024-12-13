using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class sepPeserta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterDatSepPeserta_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                column: "DatSepId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDatSepPeserta_MasterDatSep_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                column: "DatSepId",
                principalSchema: "dbo",
                principalTable: "MasterDatSep",
                principalColumn: "DatSepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDatSepPeserta_MasterDatSep_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta");

            migrationBuilder.DropIndex(
                name: "IX_MasterDatSepPeserta_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta");

            migrationBuilder.DropColumn(
                name: "DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta");
        }
    }
}
