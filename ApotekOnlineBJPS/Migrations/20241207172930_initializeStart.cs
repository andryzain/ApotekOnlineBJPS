using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApotekOnlineBJPS.Migrations
{
    public partial class initializeStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AptDatbaberkasHists",
                columns: table => new
                {
                    AptDatbaberkasHistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopbk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statuspb = table.Column<short>(type: "smallint", nullable: true),
                    Istolak = table.Column<bool>(type: "bit", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatbaberkasHists", x => x.AptDatbaberkasHistId);
                });

            migrationBuilder.CreateTable(
                name: "AptDatbafiltrasidetails",
                columns: table => new
                {
                    AptDatbafiltrasidetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopbk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idfiltrasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Noresep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatbafiltrasidetails", x => x.AptDatbafiltrasidetailId);
                });

            migrationBuilder.CreateTable(
                name: "AptDatkunjungans",
                columns: table => new
                {
                    AptDatkunjunganId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoKunjungan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglKunjungan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Refasalkunjungan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PpkKunjungan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nokapst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pisapst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdpoli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KdProgprolanis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keluhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KdDiagnosa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdsadar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sistole = table.Column<int>(type: "int", nullable: true),
                    Diastole = table.Column<int>(type: "int", nullable: true),
                    Beratbadan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tinggibadan = table.Column<int>(type: "int", nullable: true),
                    RespRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HeartRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Catatankhusus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pemeriksaanlain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rujuklanjutf = table.Column<bool>(type: "bit", nullable: true),
                    PpkRujuk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoliRujuk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PpkAsalrujuk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdtkp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdstatuspulang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglpulang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PpkPst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdjnspst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rujukbalikf = table.Column<bool>(type: "bit", nullable: true),
                    KdDiagnosa2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KdDiagnosa3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biaya = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrbId = table.Column<long>(type: "bigint", nullable: true),
                    Kddokter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoliRujukinternal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KdKunjungan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idsistem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdkc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dilayanirs = table.Column<bool>(type: "bit", nullable: true),
                    Kdtagih = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatkunjungans", x => x.AptDatkunjunganId);
                });

            migrationBuilder.CreateTable(
                name: "AptDatnofpkHists",
                columns: table => new
                {
                    AptDatnofpkHistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nofpk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatnofpkHists", x => x.AptDatnofpkHistId);
                });

            migrationBuilder.CreateTable(
                name: "AptDatnofpks",
                columns: table => new
                {
                    AptDatnofpkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nofpk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglnofpk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Jnspstfpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jmlksfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmltfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bytagfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Byverfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bystjfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tglstjfpk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Iduserfpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nipstjfpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ppkfpk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nofpkrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bytagobtfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Byverobtfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bystjobtfpk = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Userfpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglkrmfpk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Jmlrcdkrm = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nmpetugasapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nippetugasapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmkepalaapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nipkepalaapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jabkepalaapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jnspelfpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagstjfpk = table.Column<bool>(type: "bit", nullable: true),
                    Tglpengajuan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Statusfpk = table.Column<short>(type: "smallint", nullable: true),
                    Useridstjfpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bulanyan = table.Column<short>(type: "smallint", nullable: true),
                    Tahunyan = table.Column<short>(type: "smallint", nullable: true),
                    Isba = table.Column<bool>(type: "bit", nullable: true),
                    Noba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tgljthtempo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatnofpks", x => x.AptDatnofpkId);
                });

            migrationBuilder.CreateTable(
                name: "AptDatsepapprexprs",
                columns: table => new
                {
                    AptDatsepapprexprId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nosep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdppkpelsep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdppkapotek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglplgsep = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tglpengajuan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglappr = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Flag = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatsepapprexprs", x => x.AptDatsepapprexprId);
                });

            migrationBuilder.CreateTable(
                name: "AptDatsepiterasis",
                columns: table => new
                {
                    AptDatsepiterasiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refasalsjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Iterasi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatsepiterasis", x => x.AptDatsepiterasiId);
                });

            migrationBuilder.CreateTable(
                name: "AptHistupdDatobats",
                columns: table => new
                {
                    AptHistupdDatobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Noresep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jnsrobt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdobt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jmlobt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa1obt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa2obt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Serviceobt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hrgtagobt = table.Column<double>(type: "float", nullable: true),
                    Hrgverobt = table.Column<double>(type: "float", nullable: true),
                    Hrgstjobt = table.Column<double>(type: "float", nullable: true),
                    Flagcobt = table.Column<bool>(type: "bit", nullable: true),
                    Flagvobt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alasanobt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdobtver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jmlobtver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa1ver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa2ver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jhover = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Permintaan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kekuatan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Permintaanver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kekuatanver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nokonf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sediandpho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hdasarndpho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Faktorndpho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nmobatndpho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faktorver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hdasarver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Servicever = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hdasar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Faktor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmlobtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmlobtrver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Flagtanggung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catkhsobt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catkhsobtver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fdatehist = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptHistupdDatobats", x => x.AptHistupdDatobatId);
                });

            migrationBuilder.CreateTable(
                name: "AptHistupdDatreseps",
                columns: table => new
                {
                    AptHistupdDatresepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Noresep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tkprsp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Polirsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Upfrsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglpelrsp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglrsp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bytagrsp = table.Column<double>(type: "float", nullable: true),
                    Byverrsp = table.Column<double>(type: "float", nullable: true),
                    Bystjrsp = table.Column<double>(type: "float", nullable: true),
                    Flagtirsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Noresepapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kddokter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmdokter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagkirim = table.Column<bool>(type: "bit", nullable: true),
                    Tglkirim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglver = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Useridver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statuspb = table.Column<short>(type: "smallint", nullable: true),
                    Fdatehist = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptHistupdDatreseps", x => x.AptHistupdDatresepId);
                });

            migrationBuilder.CreateTable(
                name: "AptHistupdDatsjps",
                columns: table => new
                {
                    AptHistupdDatsjpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nofpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Refasalsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jnspelsjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nokapst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pisapst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdjnspeserta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdpks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mrpstsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tgldtgsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglplgsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglrjkawalsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Norjkawalsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ppkrjkawalsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagppk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Politujsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglversjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bytagsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Byversjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bystjsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmlkssjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmltsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Catkhssjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagakhirsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagentrysjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagprsklaimsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idusersjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nipstjsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ppkpelsjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flaglpstsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagpstrs = table.Column<bool>(type: "bit", nullable: true),
                    Flagrrwt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglstjkasie = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nipstjkasie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglstjrs = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Namastjrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bytagobtsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Byverobtsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bystjobtsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nocetak = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kdjnsobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Issepoffline = table.Column<bool>(type: "bit", nullable: true),
                    Flagasaldata = table.Column<int>(type: "int", nullable: true),
                    Flagiter = table.Column<bool>(type: "bit", nullable: true),
                    Flagasalrspkunjrs = table.Column<bool>(type: "bit", nullable: true),
                    Fdatehist = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptHistupdDatsjps", x => x.AptHistupdDatsjpId);
                });

            migrationBuilder.CreateTable(
                name: "AptLogdownloads",
                columns: table => new
                {
                    AptLogdownloadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Waktu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptLogdownloads", x => x.AptLogdownloadId);
                });

            migrationBuilder.CreateTable(
                name: "AptLogusers",
                columns: table => new
                {
                    AptLoguserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<long>(type: "bigint", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clientip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hostname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastlogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Lastlogout = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Lastactivity = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Isactive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptLogusers", x => x.AptLoguserId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDatketercapaiantargets",
                columns: table => new
                {
                    AptMtmDatketercapaiantargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idtargetpengobatan = table.Column<int>(type: "int", nullable: true),
                    Idketercapaiantarget = table.Column<int>(type: "int", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDatketercapaiantargets", x => x.AptMtmDatketercapaiantargetId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDatmtms",
                columns: table => new
                {
                    AptMtmDatmtmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglmtm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nohp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagmtm = table.Column<int>(type: "int", nullable: false),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDatmtms", x => x.AptMtmDatmtmId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDatriwayatkesehatans",
                columns: table => new
                {
                    AptMtmDatriwayatkesehatanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idalergiobat = table.Column<int>(type: "int", nullable: false),
                    Idalergiefek = table.Column<int>(type: "int", nullable: false),
                    Idalergirokok = table.Column<int>(type: "int", nullable: false),
                    Idalergiobattambahan = table.Column<int>(type: "int", nullable: false),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDatriwayatkesehatans", x => x.AptMtmDatriwayatkesehatanId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDattargetpengobatans",
                columns: table => new
                {
                    AptMtmDattargetpengobatanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idtargetpengobatan = table.Column<int>(type: "int", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDattargetpengobatans", x => x.AptMtmDattargetpengobatanId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDattindaklanjutpengobatans",
                columns: table => new
                {
                    AptMtmDattindaklanjutpengobatanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idtargetpengobatan = table.Column<int>(type: "int", nullable: false),
                    Idtindaklanjutpengobatan = table.Column<int>(type: "int", nullable: false),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDattindaklanjutpengobatans", x => x.AptMtmDattindaklanjutpengobatanId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmRefalergis",
                columns: table => new
                {
                    AptMtmRefalergiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idrefalergi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmalergi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmRefalergis", x => x.AptMtmRefalergiId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmRefgroupmasalahs",
                columns: table => new
                {
                    AptMtmRefgroupmasalahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idgroupmasalah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmgroupmasalah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagaktif = table.Column<bool>(type: "bit", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmRefgroupmasalahs", x => x.AptMtmRefgroupmasalahId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmReftargetpengobatans",
                columns: table => new
                {
                    AptMtmReftargetpengobatanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idtargetpengobatan = table.Column<long>(type: "bigint", nullable: false),
                    Nmtargetpengobatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmReftargetpengobatans", x => x.AptMtmReftargetpengobatanId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmReftindaklanjutpengobatans",
                columns: table => new
                {
                    AptMtmReftindaklanjutpengobatanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idtindaklanjutpengobatan = table.Column<long>(type: "bigint", nullable: false),
                    Nmtindaklanjutpengobatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmReftindaklanjutpengobatans", x => x.AptMtmReftindaklanjutpengobatanId);
                });

            migrationBuilder.CreateTable(
                name: "AptMutasiStoks",
                columns: table => new
                {
                    AptMutasiStokId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdobat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdjnsmutasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglmutasi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Jmlobat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMutasiStoks", x => x.AptMutasiStokId);
                });

            migrationBuilder.CreateTable(
                name: "AptObatlkpps",
                columns: table => new
                {
                    AptObatlkppId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idobat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idfornas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dagang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pabrik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdjnsobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edisifornas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edisilkpp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Noproduklkpp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tmt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptObatlkpps", x => x.AptObatlkppId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefalasankosongobats",
                columns: table => new
                {
                    AptRefalasankosongobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdalasankosong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmalasankosong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagaktif = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefalasankosongobats", x => x.AptRefalasankosongobatId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefasalsepApprovals",
                columns: table => new
                {
                    AptRefasalsepApprovalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ppkpelrsp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nosep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jnspelsep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglsep = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nokapst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmpst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglaju = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Useridaju = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglappr = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Useridappr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagappr = table.Column<short>(type: "smallint", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefasalsepApprovals", x => x.AptRefasalsepApprovalId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefdphos",
                columns: table => new
                {
                    AptRefdphoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdobat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdprop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jnsobt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Generik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dagang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pabrik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kekuatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sediaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sedia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Satuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Signa1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hdasar = table.Column<double>(type: "float", nullable: true),
                    Kdfaktor = table.Column<short>(type: "smallint", nullable: true),
                    Restriksi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Klsterapi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subkls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sub2kls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kodegenerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdjnsobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hmax = table.Column<short>(type: "smallint", nullable: true),
                    Rmax = table.Column<short>(type: "smallint", nullable: true),
                    Lmax = table.Column<short>(type: "smallint", nullable: true),
                    Hdiff = table.Column<short>(type: "smallint", nullable: true),
                    Tglmulai = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglakhir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Atccode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdekatalog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tgltayang = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefdphos", x => x.AptRefdphoId);
                });

            migrationBuilder.CreateTable(
                name: "AptReffiltrasitkps",
                columns: table => new
                {
                    AptReffiltrasitkpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idfiltrasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdtkp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flagaktif = table.Column<bool>(type: "bit", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptReffiltrasitkps", x => x.AptReffiltrasitkpId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefharitanggunganHists",
                columns: table => new
                {
                    AptRefharitanggunganHistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hprb = table.Column<short>(type: "smallint", nullable: true),
                    Hkronis = table.Column<short>(type: "smallint", nullable: true),
                    Hkronisrs = table.Column<short>(type: "smallint", nullable: true),
                    Hkemo = table.Column<short>(type: "smallint", nullable: true),
                    Tglmulai = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tglakhir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefharitanggunganHists", x => x.AptRefharitanggunganHistId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefharitanggungans",
                columns: table => new
                {
                    AptRefharitanggunganId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hprb = table.Column<short>(type: "smallint", nullable: true),
                    Hkronis = table.Column<short>(type: "smallint", nullable: true),
                    Hkronisrs = table.Column<short>(type: "smallint", nullable: true),
                    Hkemo = table.Column<short>(type: "smallint", nullable: true),
                    Tglmulai = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tglakhir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefharitanggungans", x => x.AptRefharitanggunganId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefjnsfiltrasis",
                columns: table => new
                {
                    AptRefjnspelsjpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idfiltrasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagaktif = table.Column<bool>(type: "bit", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefjnsfiltrasis", x => x.AptRefjnspelsjpId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefjnspelsjps",
                columns: table => new
                {
                    AptRefjnspelsjpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jnspelsjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmjnspelsjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flagaktif = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefjnspelsjps", x => x.AptRefjnspelsjpId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefsettingppks",
                columns: table => new
                {
                    AptRefsettingppkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmapoteker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmkepala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jabkepala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nipkepala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Siup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmverifikator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nppverifikator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmpetugasapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nippetugasapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checkstock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefsettingppks", x => x.AptRefsettingppkId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefspesialistdokters",
                columns: table => new
                {
                    AptRefspesialistdokterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kdspesialist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmspesialist = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefspesialistdokters", x => x.AptRefspesialistdokterId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefstatuspbs",
                columns: table => new
                {
                    AptRefstatuspbId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Statuspb = table.Column<short>(type: "smallint", nullable: false),
                    Nmstatuspb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmproses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefstatuspbs", x => x.AptRefstatuspbId);
                });

            migrationBuilder.CreateTable(
                name: "AptRefstatusverreseps",
                columns: table => new
                {
                    AptRefstatusverresepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Statusver = table.Column<short>(type: "smallint", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagaktif = table.Column<bool>(type: "bit", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptRefstatusverreseps", x => x.AptRefstatusverresepId);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDatgroupmasalahs",
                columns: table => new
                {
                    AptMtmDatgroupmasalahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idgroupmasalah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NomtmNavigationAptMtmDatmtmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDatgroupmasalahs", x => x.AptMtmDatgroupmasalahId);
                    table.ForeignKey(
                        name: "FK_AptMtmDatgroupmasalahs_AptMtmDatmtms_NomtmNavigationAptMtmDatmtmId",
                        column: x => x.NomtmNavigationAptMtmDatmtmId,
                        principalTable: "AptMtmDatmtms",
                        principalColumn: "AptMtmDatmtmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDatobats",
                columns: table => new
                {
                    AptMtmDatobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idgroupmasalah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdobat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdgroupmasalahNavigationAptMtmRefgroupmasalahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDatobats", x => x.AptMtmDatobatId);
                    table.ForeignKey(
                        name: "FK_AptMtmDatobats_AptMtmRefgroupmasalahs_IdgroupmasalahNavigationAptMtmRefgroupmasalahId",
                        column: x => x.IdgroupmasalahNavigationAptMtmRefgroupmasalahId,
                        principalTable: "AptMtmRefgroupmasalahs",
                        principalColumn: "AptMtmRefgroupmasalahId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptMtmRefmasalahs",
                columns: table => new
                {
                    AptMtmRefmasalahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idgroupmasalah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idmasalah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmmasalah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flagaktif = table.Column<bool>(type: "bit", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdgroupmasalahNavigationAptMtmRefgroupmasalahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmRefmasalahs", x => x.AptMtmRefmasalahId);
                    table.ForeignKey(
                        name: "FK_AptMtmRefmasalahs_AptMtmRefgroupmasalahs_IdgroupmasalahNavigationAptMtmRefgroupmasalahId",
                        column: x => x.IdgroupmasalahNavigationAptMtmRefgroupmasalahId,
                        principalTable: "AptMtmRefgroupmasalahs",
                        principalColumn: "AptMtmRefgroupmasalahId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatkekosonganobatNews",
                columns: table => new
                {
                    AptDatkekosonganobatNewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Kdprop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jnsapotek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accountepurch = table.Column<bool>(type: "bit", nullable: true),
                    Tglkejadian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tglsuratpemesanan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Noidpemesanepurchasing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdmetodepemesanan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdalasankosong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telahpesantptdkadakonfirm = table.Column<bool>(type: "bit", nullable: false),
                    Sudahadaevidenfarmasi = table.Column<bool>(type: "bit", nullable: false),
                    Ketalasankekosonganobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pathevidenkendala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tindaklanjut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Penyampaiankekemkeslkpp = table.Column<bool>(type: "bit", nullable: true),
                    Pathevidenlaporan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<short>(type: "smallint", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KdalasankosongNavigationAptRefalasankosongobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatkekosonganobatNews", x => x.AptDatkekosonganobatNewId);
                    table.ForeignKey(
                        name: "FK_AptDatkekosonganobatNews_AptRefalasankosongobats_KdalasankosongNavigationAptRefalasankosongobatId",
                        column: x => x.KdalasankosongNavigationAptRefalasankosongobatId,
                        principalTable: "AptRefalasankosongobats",
                        principalColumn: "AptRefalasankosongobatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatkekosonganobats",
                columns: table => new
                {
                    AptDatkekosonganobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdprop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdobat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdjnsinstansi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accountepurch = table.Column<bool>(type: "bit", nullable: true),
                    Tglkejadian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tglsuratpemesanan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kdmetodepemesanan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jmlobat = table.Column<int>(type: "int", nullable: true),
                    Kdpabrik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Namadistributor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdalasankosong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<short>(type: "smallint", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KdalasankosongNavigationAptRefalasankosongobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatkekosonganobats", x => x.AptDatkekosonganobatId);
                    table.ForeignKey(
                        name: "FK_AptDatkekosonganobats_AptRefalasankosongobats_KdalasankosongNavigationAptRefalasankosongobatId",
                        column: x => x.KdalasankosongNavigationAptRefalasankosongobatId,
                        principalTable: "AptRefalasankosongobats",
                        principalColumn: "AptRefalasankosongobatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatobats",
                columns: table => new
                {
                    AptDatobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Noresep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jnsrobt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdobt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jmlobt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa1obt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa2obt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Serviceobt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hrgtagobt = table.Column<double>(type: "float", nullable: true),
                    Hrgverobt = table.Column<double>(type: "float", nullable: true),
                    Hrgstjobt = table.Column<double>(type: "float", nullable: true),
                    Flagcobt = table.Column<bool>(type: "bit", nullable: true),
                    Flagvobt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alasanobt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdobtver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jmlobtver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa1ver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Signa2ver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jhover = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Permintaan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kekuatan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Permintaanver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kekuatanver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nokonf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sediandpho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hdasarndpho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Faktorndpho = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nmobatndpho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faktorver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hdasarver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Servicever = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Hdasar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Faktor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmlobtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmlobtrver = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Flagtanggung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catkhsobt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catkhsobtver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KdobtNavigationAptRefdphoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatobats", x => x.AptDatobatId);
                    table.ForeignKey(
                        name: "FK_AptDatobats_AptRefdphos_KdobtNavigationAptRefdphoId",
                        column: x => x.KdobtNavigationAptRefdphoId,
                        principalTable: "AptRefdphos",
                        principalColumn: "AptRefdphoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatbafiltrasis",
                columns: table => new
                {
                    AptDatbafiltrasiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopbk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idfiltrasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglfiltrasi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kasus = table.Column<int>(type: "int", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AptRefjnsfiltrasiAptRefjnspelsjpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatbafiltrasis", x => x.AptDatbafiltrasiId);
                    table.ForeignKey(
                        name: "FK_AptDatbafiltrasis_AptRefjnsfiltrasis_AptRefjnsfiltrasiAptRefjnspelsjpId",
                        column: x => x.AptRefjnsfiltrasiAptRefjnspelsjpId,
                        principalTable: "AptRefjnsfiltrasis",
                        principalColumn: "AptRefjnspelsjpId");
                });

            migrationBuilder.CreateTable(
                name: "AptDatsjps",
                columns: table => new
                {
                    AptDatsjpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nofpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Refasalsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jnspelsjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nokapst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pisapst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdjnspeserta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdpks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mrpstsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tgldtgsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglplgsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglrjkawalsjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Norjkawalsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ppkrjkawalsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagppk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Politujsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglversjp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bytagsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Byversjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bystjsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmlkssjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jmltsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Catkhssjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagakhirsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagentrysjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagprsklaimsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idusersjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nipstjsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ppkpelsjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flaglpstsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagpstrs = table.Column<bool>(type: "bit", nullable: true),
                    Flagrrwt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglstjkasie = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nipstjkasie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglstjrs = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Namastjrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bytagobtsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Byverobtsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bystjobtsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nocetak = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tstamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kdjnsobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Issepoffline = table.Column<bool>(type: "bit", nullable: true),
                    Flagasaldata = table.Column<int>(type: "int", nullable: true),
                    Flagiter = table.Column<bool>(type: "bit", nullable: true),
                    Flagasalrspkunjrs = table.Column<bool>(type: "bit", nullable: true),
                    JnspelsjpNavigationAptRefjnspelsjpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NofpkNavigationAptDatnofpkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatsjps", x => x.AptDatsjpId);
                    table.ForeignKey(
                        name: "FK_AptDatsjps_AptDatnofpks_NofpkNavigationAptDatnofpkId",
                        column: x => x.NofpkNavigationAptDatnofpkId,
                        principalTable: "AptDatnofpks",
                        principalColumn: "AptDatnofpkId");
                    table.ForeignKey(
                        name: "FK_AptDatsjps_AptRefjnspelsjps_JnspelsjpNavigationAptRefjnspelsjpId",
                        column: x => x.JnspelsjpNavigationAptRefjnspelsjpId,
                        principalTable: "AptRefjnspelsjps",
                        principalColumn: "AptRefjnspelsjpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatbapengajuanklaims",
                columns: table => new
                {
                    AptDatbapengajuanklaimID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopbk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglpb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kdkc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdppk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdtkp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tgllayanan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bulanyan = table.Column<short>(type: "smallint", nullable: true),
                    Tahunyan = table.Column<short>(type: "smallint", nullable: true),
                    Totksberkas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Totbyberkas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nmpengaju = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nippengaju = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jabpengaju = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmdirektur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nipdirektur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statuspb = table.Column<short>(type: "smallint", nullable: true),
                    Nofpk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Istolak = table.Column<short>(type: "smallint", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Flagumk = table.Column<short>(type: "smallint", nullable: false),
                    StatuspbNavigationAptRefstatuspbId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatbapengajuanklaims", x => x.AptDatbapengajuanklaimID);
                    table.ForeignKey(
                        name: "FK_AptDatbapengajuanklaims_AptRefstatuspbs_StatuspbNavigationAptRefstatuspbId",
                        column: x => x.StatuspbNavigationAptRefstatuspbId,
                        principalTable: "AptRefstatuspbs",
                        principalColumn: "AptRefstatuspbId");
                });

            migrationBuilder.CreateTable(
                name: "AptMtmDatmasalahs",
                columns: table => new
                {
                    AptMtmDatmasalahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nomtm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idmasalah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdmasalahNavigationAptMtmRefmasalahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomtmNavigationAptMtmDatmtmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptMtmDatmasalahs", x => x.AptMtmDatmasalahId);
                    table.ForeignKey(
                        name: "FK_AptMtmDatmasalahs_AptMtmDatmtms_NomtmNavigationAptMtmDatmtmId",
                        column: x => x.NomtmNavigationAptMtmDatmtmId,
                        principalTable: "AptMtmDatmtms",
                        principalColumn: "AptMtmDatmtmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AptMtmDatmasalahs_AptMtmRefmasalahs_IdmasalahNavigationAptMtmRefmasalahId",
                        column: x => x.IdmasalahNavigationAptMtmRefmasalahId,
                        principalTable: "AptMtmRefmasalahs",
                        principalColumn: "AptMtmRefmasalahId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatkekosonganobatdetilNews",
                columns: table => new
                {
                    AptDatkekosonganobatdetilNewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Kdgenerikobat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmgenerikobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Periode = table.Column<int>(type: "int", nullable: false),
                    Jnsobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sediaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kekuatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmpatendagangobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kdindustrifarmasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industrifarmasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industrifarmasilain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kddistributorfarmasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmdistributor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmdistributorlain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<short>(type: "smallint", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNavigationAptDatkekosonganobatNewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatkekosonganobatdetilNews", x => x.AptDatkekosonganobatdetilNewId);
                    table.ForeignKey(
                        name: "FK_AptDatkekosonganobatdetilNews_AptDatkekosonganobatNews_IdNavigationAptDatkekosonganobatNewId",
                        column: x => x.IdNavigationAptDatkekosonganobatNewId,
                        principalTable: "AptDatkekosonganobatNews",
                        principalColumn: "AptDatkekosonganobatNewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatreseps",
                columns: table => new
                {
                    AptDatresepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Noresep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tkprsp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Polirsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Upfrsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglpelrsp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglrsp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bytagrsp = table.Column<double>(type: "float", nullable: true),
                    Byverrsp = table.Column<double>(type: "float", nullable: true),
                    Bystjrsp = table.Column<double>(type: "float", nullable: true),
                    Flagtirsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Noresepapt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kddokter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmdokter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagkirim = table.Column<bool>(type: "bit", nullable: true),
                    Tglkirim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tglver = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Useridver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statuspb = table.Column<short>(type: "smallint", nullable: true),
                    NosjpNavigationAptDatsjpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatreseps", x => x.AptDatresepId);
                    table.ForeignKey(
                        name: "FK_AptDatreseps_AptDatsjps_NosjpNavigationAptDatsjpId",
                        column: x => x.NosjpNavigationAptDatsjpId,
                        principalTable: "AptDatsjps",
                        principalColumn: "AptDatsjpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptDatbaberkass",
                columns: table => new
                {
                    AptDatbaberkasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopbk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statuspb = table.Column<short>(type: "smallint", nullable: false),
                    Nosurat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tglentri = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tglba = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Noreff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglselesai = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tgljthtempo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nmpetugas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nippetugas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nmdirektur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nipdirektur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Isbaotomatis = table.Column<bool>(type: "bit", nullable: false),
                    AptDatbapengajuanklaimID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AptRefstatuspbId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatbaberkass", x => x.AptDatbaberkasId);
                    table.ForeignKey(
                        name: "FK_AptDatbaberkass_AptDatbapengajuanklaims_AptDatbapengajuanklaimID",
                        column: x => x.AptDatbapengajuanklaimID,
                        principalTable: "AptDatbapengajuanklaims",
                        principalColumn: "AptDatbapengajuanklaimID");
                    table.ForeignKey(
                        name: "FK_AptDatbaberkass_AptRefstatuspbs_AptRefstatuspbId",
                        column: x => x.AptRefstatuspbId,
                        principalTable: "AptRefstatuspbs",
                        principalColumn: "AptRefstatuspbId");
                });

            migrationBuilder.CreateTable(
                name: "AptDatbapengajuanklaimdetails",
                columns: table => new
                {
                    AptDatbapengajuanklaimdetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopbk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nosjp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Noresep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refasalsjp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nokapst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nmpst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglrsp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bytagsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Byversjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bystjsjp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kdjnsobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tglverpb = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Statusver = table.Column<short>(type: "smallint", nullable: true),
                    Userver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Flaguserver = table.Column<bool>(type: "bit", nullable: false),
                    NopbkNavigationAptDatbapengajuanklaimID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusverNavigationAptRefstatusverresepId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatbapengajuanklaimdetails", x => x.AptDatbapengajuanklaimdetailId);
                    table.ForeignKey(
                        name: "FK_AptDatbapengajuanklaimdetails_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimID",
                        column: x => x.NopbkNavigationAptDatbapengajuanklaimID,
                        principalTable: "AptDatbapengajuanklaims",
                        principalColumn: "AptDatbapengajuanklaimID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AptDatbapengajuanklaimdetails_AptRefstatusverreseps_StatusverNavigationAptRefstatusverresepId",
                        column: x => x.StatusverNavigationAptRefstatusverresepId,
                        principalTable: "AptRefstatusverreseps",
                        principalColumn: "AptRefstatusverresepId");
                });

            migrationBuilder.CreateTable(
                name: "AptDatbapengajuanklaimjenisobats",
                columns: table => new
                {
                    AptDatbapengajuanklaimjenisobatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nopbk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdjnsobat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jmlrsptag = table.Column<int>(type: "int", nullable: true),
                    Jmlrspver = table.Column<int>(type: "int", nullable: true),
                    Keterangantag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keteranganver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Luser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NopbkNavigationAptDatbapengajuanklaimID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptDatbapengajuanklaimjenisobats", x => x.AptDatbapengajuanklaimjenisobatId);
                    table.ForeignKey(
                        name: "FK_AptDatbapengajuanklaimjenisobats_AptDatbapengajuanklaims_NopbkNavigationAptDatbapengajuanklaimID",
                        column: x => x.NopbkNavigationAptDatbapengajuanklaimID,
                        principalTable: "AptDatbapengajuanklaims",
                        principalColumn: "AptDatbapengajuanklaimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AptDatbaberkass_AptDatbapengajuanklaimID",
                table: "AptDatbaberkass",
                column: "AptDatbapengajuanklaimID");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatbaberkass_AptRefstatuspbId",
                table: "AptDatbaberkass",
                column: "AptRefstatuspbId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatbafiltrasis_AptRefjnsfiltrasiAptRefjnspelsjpId",
                table: "AptDatbafiltrasis",
                column: "AptRefjnsfiltrasiAptRefjnspelsjpId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatbapengajuanklaimdetails_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimdetails",
                column: "NopbkNavigationAptDatbapengajuanklaimID");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatbapengajuanklaimdetails_StatusverNavigationAptRefstatusverresepId",
                table: "AptDatbapengajuanklaimdetails",
                column: "StatusverNavigationAptRefstatusverresepId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatbapengajuanklaimjenisobats_NopbkNavigationAptDatbapengajuanklaimID",
                table: "AptDatbapengajuanklaimjenisobats",
                column: "NopbkNavigationAptDatbapengajuanklaimID");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatbapengajuanklaims_StatuspbNavigationAptRefstatuspbId",
                table: "AptDatbapengajuanklaims",
                column: "StatuspbNavigationAptRefstatuspbId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatkekosonganobatdetilNews_IdNavigationAptDatkekosonganobatNewId",
                table: "AptDatkekosonganobatdetilNews",
                column: "IdNavigationAptDatkekosonganobatNewId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatkekosonganobatNews_KdalasankosongNavigationAptRefalasankosongobatId",
                table: "AptDatkekosonganobatNews",
                column: "KdalasankosongNavigationAptRefalasankosongobatId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatkekosonganobats_KdalasankosongNavigationAptRefalasankosongobatId",
                table: "AptDatkekosonganobats",
                column: "KdalasankosongNavigationAptRefalasankosongobatId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatobats_KdobtNavigationAptRefdphoId",
                table: "AptDatobats",
                column: "KdobtNavigationAptRefdphoId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatreseps_NosjpNavigationAptDatsjpId",
                table: "AptDatreseps",
                column: "NosjpNavigationAptDatsjpId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatsjps_JnspelsjpNavigationAptRefjnspelsjpId",
                table: "AptDatsjps",
                column: "JnspelsjpNavigationAptRefjnspelsjpId");

            migrationBuilder.CreateIndex(
                name: "IX_AptDatsjps_NofpkNavigationAptDatnofpkId",
                table: "AptDatsjps",
                column: "NofpkNavigationAptDatnofpkId");

            migrationBuilder.CreateIndex(
                name: "IX_AptMtmDatgroupmasalahs_NomtmNavigationAptMtmDatmtmId",
                table: "AptMtmDatgroupmasalahs",
                column: "NomtmNavigationAptMtmDatmtmId");

            migrationBuilder.CreateIndex(
                name: "IX_AptMtmDatmasalahs_IdmasalahNavigationAptMtmRefmasalahId",
                table: "AptMtmDatmasalahs",
                column: "IdmasalahNavigationAptMtmRefmasalahId");

            migrationBuilder.CreateIndex(
                name: "IX_AptMtmDatmasalahs_NomtmNavigationAptMtmDatmtmId",
                table: "AptMtmDatmasalahs",
                column: "NomtmNavigationAptMtmDatmtmId");

            migrationBuilder.CreateIndex(
                name: "IX_AptMtmDatobats_IdgroupmasalahNavigationAptMtmRefgroupmasalahId",
                table: "AptMtmDatobats",
                column: "IdgroupmasalahNavigationAptMtmRefgroupmasalahId");

            migrationBuilder.CreateIndex(
                name: "IX_AptMtmRefmasalahs_IdgroupmasalahNavigationAptMtmRefgroupmasalahId",
                table: "AptMtmRefmasalahs",
                column: "IdgroupmasalahNavigationAptMtmRefgroupmasalahId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AptDatbaberkasHists");

            migrationBuilder.DropTable(
                name: "AptDatbaberkass");

            migrationBuilder.DropTable(
                name: "AptDatbafiltrasidetails");

            migrationBuilder.DropTable(
                name: "AptDatbafiltrasis");

            migrationBuilder.DropTable(
                name: "AptDatbapengajuanklaimdetails");

            migrationBuilder.DropTable(
                name: "AptDatbapengajuanklaimjenisobats");

            migrationBuilder.DropTable(
                name: "AptDatkekosonganobatdetilNews");

            migrationBuilder.DropTable(
                name: "AptDatkekosonganobats");

            migrationBuilder.DropTable(
                name: "AptDatkunjungans");

            migrationBuilder.DropTable(
                name: "AptDatnofpkHists");

            migrationBuilder.DropTable(
                name: "AptDatobats");

            migrationBuilder.DropTable(
                name: "AptDatreseps");

            migrationBuilder.DropTable(
                name: "AptDatsepapprexprs");

            migrationBuilder.DropTable(
                name: "AptDatsepiterasis");

            migrationBuilder.DropTable(
                name: "AptHistupdDatobats");

            migrationBuilder.DropTable(
                name: "AptHistupdDatreseps");

            migrationBuilder.DropTable(
                name: "AptHistupdDatsjps");

            migrationBuilder.DropTable(
                name: "AptLogdownloads");

            migrationBuilder.DropTable(
                name: "AptLogusers");

            migrationBuilder.DropTable(
                name: "AptMtmDatgroupmasalahs");

            migrationBuilder.DropTable(
                name: "AptMtmDatketercapaiantargets");

            migrationBuilder.DropTable(
                name: "AptMtmDatmasalahs");

            migrationBuilder.DropTable(
                name: "AptMtmDatobats");

            migrationBuilder.DropTable(
                name: "AptMtmDatriwayatkesehatans");

            migrationBuilder.DropTable(
                name: "AptMtmDattargetpengobatans");

            migrationBuilder.DropTable(
                name: "AptMtmDattindaklanjutpengobatans");

            migrationBuilder.DropTable(
                name: "AptMtmRefalergis");

            migrationBuilder.DropTable(
                name: "AptMtmReftargetpengobatans");

            migrationBuilder.DropTable(
                name: "AptMtmReftindaklanjutpengobatans");

            migrationBuilder.DropTable(
                name: "AptMutasiStoks");

            migrationBuilder.DropTable(
                name: "AptObatlkpps");

            migrationBuilder.DropTable(
                name: "AptRefasalsepApprovals");

            migrationBuilder.DropTable(
                name: "AptReffiltrasitkps");

            migrationBuilder.DropTable(
                name: "AptRefharitanggunganHists");

            migrationBuilder.DropTable(
                name: "AptRefharitanggungans");

            migrationBuilder.DropTable(
                name: "AptRefsettingppks");

            migrationBuilder.DropTable(
                name: "AptRefspesialistdokters");

            migrationBuilder.DropTable(
                name: "AptRefjnsfiltrasis");

            migrationBuilder.DropTable(
                name: "AptRefstatusverreseps");

            migrationBuilder.DropTable(
                name: "AptDatbapengajuanklaims");

            migrationBuilder.DropTable(
                name: "AptDatkekosonganobatNews");

            migrationBuilder.DropTable(
                name: "AptRefdphos");

            migrationBuilder.DropTable(
                name: "AptDatsjps");

            migrationBuilder.DropTable(
                name: "AptMtmDatmtms");

            migrationBuilder.DropTable(
                name: "AptMtmRefmasalahs");

            migrationBuilder.DropTable(
                name: "AptRefstatuspbs");

            migrationBuilder.DropTable(
                name: "AptRefalasankosongobats");

            migrationBuilder.DropTable(
                name: "AptDatnofpks");

            migrationBuilder.DropTable(
                name: "AptRefjnspelsjps");

            migrationBuilder.DropTable(
                name: "AptMtmRefgroupmasalahs");
        }
    }
}
