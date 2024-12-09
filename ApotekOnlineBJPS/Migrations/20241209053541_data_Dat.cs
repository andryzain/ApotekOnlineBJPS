using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class data_Dat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbaberkass_AptDatbapengajuanklaims_AptDatbapengajuanklaimID",
                table: "AptDatbaberkass");

            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbafiltrasis_AptRefjnsfiltrasis_AptRefjnsfiltrasiAptRefjnspelsjpId",
                table: "AptDatbafiltrasis");

            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbapengajuanklaimdetails_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimdetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbapengajuanklaimjenisobats_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimjenisobats");

            migrationBuilder.RenameColumn(
                name: "AptRefjnspelsjpId",
                table: "AptRefjnsfiltrasis",
                newName: "AptRefjnsfiltrasiId");

            migrationBuilder.RenameColumn(
                name: "AptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaims",
                newName: "AptDatbapengajuanklaimId");

            migrationBuilder.RenameColumn(
                name: "NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimjenisobats",
                newName: "NopbkNavigationAptDatbapengajuanklaimId");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbapengajuanklaimjenisobats_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimjenisobats",
                newName: "IX_AptDatbapengajuanklaimjenisobats_NopbkNavigationAptDatbapengajuanklaimId");

            migrationBuilder.RenameColumn(
                name: "NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimdetails",
                newName: "NopbkNavigationAptDatbapengajuanklaimId");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbapengajuanklaimdetails_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimdetails",
                newName: "IX_AptDatbapengajuanklaimdetails_NopbkNavigationAptDatbapengajuanklaimId");

            migrationBuilder.RenameColumn(
                name: "AptRefjnsfiltrasiAptRefjnspelsjpId",
                table: "AptDatbafiltrasis",
                newName: "AptRefjnsfiltrasiId");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbafiltrasis_AptRefjnsfiltrasiAptRefjnspelsjpId",
                table: "AptDatbafiltrasis",
                newName: "IX_AptDatbafiltrasis_AptRefjnsfiltrasiId");

            migrationBuilder.RenameColumn(
                name: "AptDatbapengajuanklaimID",
                table: "AptDatbaberkass",
                newName: "AptDatbapengajuanklaimId");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbaberkass_AptDatbapengajuanklaimID",
                table: "AptDatbaberkass",
                newName: "IX_AptDatbaberkass_AptDatbapengajuanklaimId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbaberkass_AptDatbapengajuanklaims_AptDatbapengajuanklaimId",
                table: "AptDatbaberkass",
                column: "AptDatbapengajuanklaimId",
                principalTable: "AptDatbapengajuanklaims",
                principalColumn: "AptDatbapengajuanklaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbafiltrasis_AptRefjnsfiltrasis_AptRefjnsfiltrasiId",
                table: "AptDatbafiltrasis",
                column: "AptRefjnsfiltrasiId",
                principalTable: "AptRefjnsfiltrasis",
                principalColumn: "AptRefjnsfiltrasiId");

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbapengajuanklaimdetails_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimdetails",
                column: "NopbkNavigationAptDatbapengajuanklaimId",
                principalTable: "AptDatbapengajuanklaims",
                principalColumn: "AptDatbapengajuanklaimId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbapengajuanklaimjenisobats_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimjenisobats",
                column: "NopbkNavigationAptDatbapengajuanklaimId",
                principalTable: "AptDatbapengajuanklaims",
                principalColumn: "AptDatbapengajuanklaimId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbaberkass_AptDatbapengajuanklaims_AptDatbapengajuanklaimId",
                table: "AptDatbaberkass");

            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbafiltrasis_AptRefjnsfiltrasis_AptRefjnsfiltrasiId",
                table: "AptDatbafiltrasis");

            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbapengajuanklaimdetails_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimdetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AptDatbapengajuanklaimjenisobats_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimjenisobats");

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

            migrationBuilder.RenameColumn(
                name: "AptRefjnsfiltrasiId",
                table: "AptRefjnsfiltrasis",
                newName: "AptRefjnspelsjpId");

            migrationBuilder.RenameColumn(
                name: "AptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaims",
                newName: "AptDatbapengajuanklaimID");

            migrationBuilder.RenameColumn(
                name: "NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimjenisobats",
                newName: "NopbkNavigationAptDatbapengajuanklaimID");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbapengajuanklaimjenisobats_NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimjenisobats",
                newName: "IX_AptDatbapengajuanklaimjenisobats_NopbkNavigationAptDatbapengajuanklaimID");

            migrationBuilder.RenameColumn(
                name: "NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimdetails",
                newName: "NopbkNavigationAptDatbapengajuanklaimID");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbapengajuanklaimdetails_NopbkNavigationAptDatbapengajuanklaimId",
                table: "AptDatbapengajuanklaimdetails",
                newName: "IX_AptDatbapengajuanklaimdetails_NopbkNavigationAptDatbapengajuanklaimID");

            migrationBuilder.RenameColumn(
                name: "AptRefjnsfiltrasiId",
                table: "AptDatbafiltrasis",
                newName: "AptRefjnsfiltrasiAptRefjnspelsjpId");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbafiltrasis_AptRefjnsfiltrasiId",
                table: "AptDatbafiltrasis",
                newName: "IX_AptDatbafiltrasis_AptRefjnsfiltrasiAptRefjnspelsjpId");

            migrationBuilder.RenameColumn(
                name: "AptDatbapengajuanklaimId",
                table: "AptDatbaberkass",
                newName: "AptDatbapengajuanklaimID");

            migrationBuilder.RenameIndex(
                name: "IX_AptDatbaberkass_AptDatbapengajuanklaimId",
                table: "AptDatbaberkass",
                newName: "IX_AptDatbaberkass_AptDatbapengajuanklaimID");

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbaberkass_AptDatbapengajuanklaims_AptDatbapengajuanklaimID",
                table: "AptDatbaberkass",
                column: "AptDatbapengajuanklaimID",
                principalTable: "AptDatbapengajuanklaims",
                principalColumn: "AptDatbapengajuanklaimID");

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbafiltrasis_AptRefjnsfiltrasis_AptRefjnsfiltrasiAptRefjnspelsjpId",
                table: "AptDatbafiltrasis",
                column: "AptRefjnsfiltrasiAptRefjnspelsjpId",
                principalTable: "AptRefjnsfiltrasis",
                principalColumn: "AptRefjnspelsjpId");

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbapengajuanklaimdetails_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimdetails",
                column: "NopbkNavigationAptDatbapengajuanklaimID",
                principalTable: "AptDatbapengajuanklaims",
                principalColumn: "AptDatbapengajuanklaimID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AptDatbapengajuanklaimjenisobats_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimjenisobats",
                column: "NopbkNavigationAptDatbapengajuanklaimID",
                principalTable: "AptDatbapengajuanklaims",
                principalColumn: "AptDatbapengajuanklaimID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
