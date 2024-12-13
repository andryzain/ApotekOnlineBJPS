using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Areas.MasterData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ApotekOnlineBJPS.Areas.Master.Models;

namespace ApotekOnlineBJPS.Repositories
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region Apotek Online
        public DbSet<AptDatbaberkas> AptDatbaberkass { get; set; }
        public DbSet<AptDatbaberkasHist> AptDatbaberkasHists { get; set; }
        public DbSet<AptDatbafiltrasi> AptDatbafiltrasis { get; set; }
        public DbSet<AptDatbafiltrasidetail> AptDatbafiltrasidetails { get; set; }
        public DbSet<AptDatbapengajuanklaim> AptDatbapengajuanklaims { get; set; }
        public DbSet<AptDatbapengajuanklaimdetail> AptDatbapengajuanklaimdetails { get; set; }
        public DbSet<AptDatbapengajuanklaimjenisobat> AptDatbapengajuanklaimjenisobats { get; set; }
        public DbSet<AptDatkekosonganobat> AptDatkekosonganobats { get; set; }
        public DbSet<AptDatkekosonganobatNew> AptDatkekosonganobatNews { get; set; }
        public DbSet<AptDatkekosonganobatdetilNew> AptDatkekosonganobatdetilNews { get; set; }
        public DbSet<AptDatkunjungan> AptDatkunjungans { get; set; }
        public DbSet<AptDatnofpk> AptDatnofpks { get; set; }
        public DbSet<AptDatnofpkHist> AptDatnofpkHists { get; set; }
        public DbSet<AptDatobat> AptDatobats { get; set; }
        public DbSet<AptDatresep> AptDatreseps { get; set; }
        public DbSet<AptDatsepapprexpr> AptDatsepapprexprs { get; set; }
        public DbSet<AptDatsepiterasi> AptDatsepiterasis { get; set; }
        public DbSet<AptDatsjp> AptDatsjps { get; set; }
        public DbSet<AptHistupdDatobat> AptHistupdDatobats { get; set; }
        public DbSet<AptHistupdDatresep> AptHistupdDatreseps { get; set; }
        public DbSet<AptHistupdDatsjp> AptHistupdDatsjps { get; set; }
        public DbSet<AptLogdownload> AptLogdownloads { get; set; }
        public DbSet<AptLoguser> AptLogusers { get; set; }
        public DbSet<AptMtmDatgroupmasalah> AptMtmDatgroupmasalahs { get; set; }
        public DbSet<AptMtmDatketercapaiantarget> AptMtmDatketercapaiantargets { get; set; }
        public DbSet<AptMtmDatmasalah> AptMtmDatmasalahs { get; set; }
        public DbSet<AptMtmDatmtm> AptMtmDatmtms { get; set; }
        public DbSet<AptMtmDatobat> AptMtmDatobats { get; set; }
        public DbSet<AptMtmDatriwayatkesehatan> AptMtmDatriwayatkesehatans { get; set; }
        public DbSet<AptMtmDattargetpengobatan> AptMtmDattargetpengobatans { get; set; }
        public DbSet<AptMtmDattindaklanjutpengobatan> AptMtmDattindaklanjutpengobatans { get; set; }
        public DbSet<AptMtmRefalergi> AptMtmRefalergis { get; set; }
        public DbSet<AptMtmRefgroupmasalah> AptMtmRefgroupmasalahs { get; set; }
        public DbSet<AptMtmRefmasalah> AptMtmRefmasalahs { get; set; }
        public DbSet<AptMtmReftargetpengobatan> AptMtmReftargetpengobatans { get; set; }
        public DbSet<AptMtmReftindaklanjutpengobatan> AptMtmReftindaklanjutpengobatans { get; set; }
        public DbSet<AptMutasiStok> AptMutasiStoks { get; set; }
        public DbSet<AptObatlkpp> AptObatlkpps { get; set; }
        public DbSet<AptRefalasankosongobat> AptRefalasankosongobats { get; set; }
        public DbSet<AptRefasalsepApproval> AptRefasalsepApprovals { get; set; }
        public DbSet<AptRefdpho> AptRefdphos { get; set; }
        public DbSet<AptReffiltrasitkp> AptReffiltrasitkps { get; set; }
        public DbSet<AptRefharitanggungan> AptRefharitanggungans { get; set; }
        public DbSet<AptRefharitanggunganHist> AptRefharitanggunganHists { get; set; }
        public DbSet<AptRefjnsfiltrasi> AptRefjnsfiltrasis { get; set; }
        public DbSet<AptRefjnspelsjp> AptRefjnspelsjps { get; set; }
        public DbSet<AptRefsettingppk> AptRefsettingppks { get; set; }
        public DbSet<AptRefspesialistdokter> AptRefspesialistdokters { get; set; }
        public DbSet<AptRefstatuspb> AptRefstatuspbs { get; set; }
        public DbSet<AptRefstatusverresep> AptRefstatusverreseps { get; set; }

        #endregion

        #region Konfigurasi
        public DbSet<DatLogin> DatLogins { get; set; }
        public DbSet<UserActive> UserActives { get; set; }
        public DbSet<DatSepPeserta> DatSepPesertas { get; set; }
        public DbSet<DatDokter> DatDokters { get; set; }
        public DbSet<DatStock> DatStocks { get; set; }
        public DbSet<DatObat> DatObats { get; set; }
        public DbSet<ResepPRB> ResepPRBs { get; set; }
        public DbSet<DatPRBMTMPCare> DatPRBMTMPCares { get; set; }
        public DbSet<DatResep> DatReseps { get; set; }
        public DbSet<DatResepMasuk> DatResepMasuks { get; set; }
        public DbSet<DatSep> DatSeps { get; set; }
        public DbSet<RefProfilPPK> RefProfilPPKs { get; set; }
        public DbSet<DatPendataanResepMasuk> DatPendataanResepMasuks { get; set; }
        #endregion
    }
}
