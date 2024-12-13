using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class sepPesertas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDatSepPeserta_MasterDatSep_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta");

            migrationBuilder.AlterColumn<Guid>(
                name: "DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDatSepPeserta_MasterDatSep_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                column: "DatSepId",
                principalSchema: "dbo",
                principalTable: "MasterDatSep",
                principalColumn: "DatSepId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDatSepPeserta_MasterDatSep_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta");

            migrationBuilder.AlterColumn<Guid>(
                name: "DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDatSepPeserta_MasterDatSep_DatSepId",
                schema: "dbo",
                table: "MasterDatSepPeserta",
                column: "DatSepId",
                principalSchema: "dbo",
                principalTable: "MasterDatSep",
                principalColumn: "DatSepId");
        }
    }
}
