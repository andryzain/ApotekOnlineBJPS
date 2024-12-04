using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ApotekOnlineBJPS.Models;

namespace ApotekOnlineBJPS.Context
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AptDatbaberka> AptDatbaberkas { get; set; } = null!;
        public virtual DbSet<AptDatbaberkasHist> AptDatbaberkasHists { get; set; } = null!;
        public virtual DbSet<AptDatbafiltrasi> AptDatbafiltrasis { get; set; } = null!;
        public virtual DbSet<AptDatbafiltrasidetail> AptDatbafiltrasidetails { get; set; } = null!;
        public virtual DbSet<AptDatbapengajuanklaim> AptDatbapengajuanklaims { get; set; } = null!;
        public virtual DbSet<AptDatbapengajuanklaimdetail> AptDatbapengajuanklaimdetails { get; set; } = null!;
        public virtual DbSet<AptDatbapengajuanklaimjenisobat> AptDatbapengajuanklaimjenisobats { get; set; } = null!;
        public virtual DbSet<AptDatkekosonganobat> AptDatkekosonganobats { get; set; } = null!;
        public virtual DbSet<AptDatkekosonganobatNew> AptDatkekosonganobatNews { get; set; } = null!;
        public virtual DbSet<AptDatkekosonganobatdetilNew> AptDatkekosonganobatdetilNews { get; set; } = null!;
        public virtual DbSet<AptDatkunjungan> AptDatkunjungans { get; set; } = null!;
        public virtual DbSet<AptDatnofpk> AptDatnofpks { get; set; } = null!;
        public virtual DbSet<AptDatnofpkHist> AptDatnofpkHists { get; set; } = null!;
        public virtual DbSet<AptDatobat> AptDatobats { get; set; } = null!;
        public virtual DbSet<AptDatresep> AptDatreseps { get; set; } = null!;
        public virtual DbSet<AptDatsepapprexpr> AptDatsepapprexprs { get; set; } = null!;
        public virtual DbSet<AptDatsepiterasi> AptDatsepiterasis { get; set; } = null!;
        public virtual DbSet<AptDatsjp> AptDatsjps { get; set; } = null!;
        public virtual DbSet<AptHistupdDatobat> AptHistupdDatobats { get; set; } = null!;
        public virtual DbSet<AptHistupdDatresep> AptHistupdDatreseps { get; set; } = null!;
        public virtual DbSet<AptHistupdDatsjp> AptHistupdDatsjps { get; set; } = null!;
        public virtual DbSet<AptLogdownload> AptLogdownloads { get; set; } = null!;
        public virtual DbSet<AptLoguser> AptLogusers { get; set; } = null!;
        public virtual DbSet<AptMtmDatgroupmasalah> AptMtmDatgroupmasalahs { get; set; } = null!;
        public virtual DbSet<AptMtmDatketercapaiantarget> AptMtmDatketercapaiantargets { get; set; } = null!;
        public virtual DbSet<AptMtmDatmasalah> AptMtmDatmasalahs { get; set; } = null!;
        public virtual DbSet<AptMtmDatmtm> AptMtmDatmtms { get; set; } = null!;
        public virtual DbSet<AptMtmDatobat> AptMtmDatobats { get; set; } = null!;
        public virtual DbSet<AptMtmDatriwayatkesehatan> AptMtmDatriwayatkesehatans { get; set; } = null!;
        public virtual DbSet<AptMtmDattargetpengobatan> AptMtmDattargetpengobatans { get; set; } = null!;
        public virtual DbSet<AptMtmDattindaklanjutpengobatan> AptMtmDattindaklanjutpengobatans { get; set; } = null!;
        public virtual DbSet<AptMtmRefalergi> AptMtmRefalergis { get; set; } = null!;
        public virtual DbSet<AptMtmRefgroupmasalah> AptMtmRefgroupmasalahs { get; set; } = null!;
        public virtual DbSet<AptMtmRefmasalah> AptMtmRefmasalahs { get; set; } = null!;
        public virtual DbSet<AptMtmReftargetpengobatan> AptMtmReftargetpengobatans { get; set; } = null!;
        public virtual DbSet<AptMtmReftindaklanjutpengobatan> AptMtmReftindaklanjutpengobatans { get; set; } = null!;
        public virtual DbSet<AptMutasiStok> AptMutasiStoks { get; set; } = null!;
        public virtual DbSet<AptObatlkpp> AptObatlkpps { get; set; } = null!;
        public virtual DbSet<AptRefalasankosongobat> AptRefalasankosongobats { get; set; } = null!;
        public virtual DbSet<AptRefasalsepApproval> AptRefasalsepApprovals { get; set; } = null!;
        public virtual DbSet<AptRefdpho> AptRefdphos { get; set; } = null!;
        public virtual DbSet<AptReffiltrasitkp> AptReffiltrasitkps { get; set; } = null!;
        public virtual DbSet<AptRefharitanggungan> AptRefharitanggungans { get; set; } = null!;
        public virtual DbSet<AptRefharitanggunganHist> AptRefharitanggunganHists { get; set; } = null!;
        public virtual DbSet<AptRefjnsfiltrasi> AptRefjnsfiltrasis { get; set; } = null!;
        public virtual DbSet<AptRefjnspelsjp> AptRefjnspelsjps { get; set; } = null!;
        public virtual DbSet<AptRefsettingppk> AptRefsettingppks { get; set; } = null!;
        public virtual DbSet<AptRefspesialistdokter> AptRefspesialistdokters { get; set; } = null!;
        public virtual DbSet<AptRefstatuspb> AptRefstatuspbs { get; set; } = null!;
        public virtual DbSet<AptRefstatusverresep> AptRefstatusverreseps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=dbPelayanan;Username=postgres;Password=adminweb;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AptDatbaberka>(entity =>
            {
                entity.HasKey(e => new { e.Nopbk, e.Statuspb })
                    .HasName("idx_16559_pk_apt_datbaberkas");

                entity.ToTable("apt_datbaberkas", "dbo");

                entity.Property(e => e.Nopbk).HasColumnName("nopbk");

                entity.Property(e => e.Statuspb).HasColumnName("statuspb");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Isbaotomatis).HasColumnName("isbaotomatis");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nipdirektur).HasColumnName("nipdirektur");

                entity.Property(e => e.Nippetugas).HasColumnName("nippetugas");

                entity.Property(e => e.Nmdirektur).HasColumnName("nmdirektur");

                entity.Property(e => e.Nmpetugas).HasColumnName("nmpetugas");

                entity.Property(e => e.Noreff).HasColumnName("noreff");

                entity.Property(e => e.Nosurat).HasColumnName("nosurat");

                entity.Property(e => e.Tglba).HasColumnName("tglba");

                entity.Property(e => e.Tglentri)
                    .HasColumnName("tglentri")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Tgljthtempo).HasColumnName("tgljthtempo");

                entity.Property(e => e.Tglselesai).HasColumnName("tglselesai");

                entity.HasOne(d => d.NopbkNavigation)
                    .WithMany(p => p.AptDatbaberkas)
                    .HasForeignKey(d => d.Nopbk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datbaberkas_apt_datbapengajuanklaim");

                entity.HasOne(d => d.StatuspbNavigation)
                    .WithMany(p => p.AptDatbaberkas)
                    .HasForeignKey(d => d.Statuspb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datbaberkas_apt_refstatuspb");
            });

            modelBuilder.Entity<AptDatbaberkasHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_datbaberkas_hist", "dbo");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Istolak).HasColumnName("istolak");

                entity.Property(e => e.Nopbk).HasColumnName("nopbk");

                entity.Property(e => e.Statuspb).HasColumnName("statuspb");
            });

            modelBuilder.Entity<AptDatbafiltrasi>(entity =>
            {
                entity.HasKey(e => new { e.Nopbk, e.Idfiltrasi })
                    .HasName("idx_16573_pk_apt_datbafiltrasi");

                entity.ToTable("apt_datbafiltrasi", "dbo");

                entity.Property(e => e.Nopbk).HasColumnName("nopbk");

                entity.Property(e => e.Idfiltrasi).HasColumnName("idfiltrasi");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Kasus).HasColumnName("kasus");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Tglfiltrasi).HasColumnName("tglfiltrasi");

                entity.HasOne(d => d.IdfiltrasiNavigation)
                    .WithMany(p => p.AptDatbafiltrasis)
                    .HasForeignKey(d => d.Idfiltrasi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datbafiltrasi_apt_refjnsfiltrasi");
            });

            modelBuilder.Entity<AptDatbafiltrasidetail>(entity =>
            {
                entity.HasKey(e => new { e.Nopbk, e.Idfiltrasi, e.Nosjp, e.Noresep })
                    .HasName("idx_16579_pk_apt_datbafiltrasidetail");

                entity.ToTable("apt_datbafiltrasidetail", "dbo");

                entity.Property(e => e.Nopbk).HasColumnName("nopbk");

                entity.Property(e => e.Idfiltrasi).HasColumnName("idfiltrasi");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Noresep).HasColumnName("noresep");
            });

            modelBuilder.Entity<AptDatbapengajuanklaim>(entity =>
            {
                entity.HasKey(e => e.Nopbk)
                    .HasName("idx_16584_pk_apt_datbapengajuanklaim");

                entity.ToTable("apt_datbapengajuanklaim", "dbo");

                entity.Property(e => e.Nopbk).HasColumnName("nopbk");

                entity.Property(e => e.Bulanyan).HasColumnName("bulanyan");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagumk)
                    .HasColumnName("flagumk")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Istolak)
                    .HasColumnName("istolak")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Jabpengaju).HasColumnName("jabpengaju");

                entity.Property(e => e.Kdkc).HasColumnName("kdkc");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Kdtkp).HasColumnName("kdtkp");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nipdirektur).HasColumnName("nipdirektur");

                entity.Property(e => e.Nippengaju).HasColumnName("nippengaju");

                entity.Property(e => e.Nmdirektur).HasColumnName("nmdirektur");

                entity.Property(e => e.Nmpengaju).HasColumnName("nmpengaju");

                entity.Property(e => e.Nofpk).HasColumnName("nofpk");

                entity.Property(e => e.Statuspb)
                    .HasColumnName("statuspb")
                    .HasDefaultValueSql("'1'::smallint");

                entity.Property(e => e.Tahunyan).HasColumnName("tahunyan");

                entity.Property(e => e.Tgllayanan).HasColumnName("tgllayanan");

                entity.Property(e => e.Tglpb).HasColumnName("tglpb");

                entity.Property(e => e.Totbyberkas).HasColumnName("totbyberkas");

                entity.Property(e => e.Totksberkas).HasColumnName("totksberkas");

                entity.HasOne(d => d.StatuspbNavigation)
                    .WithMany(p => p.AptDatbapengajuanklaims)
                    .HasForeignKey(d => d.Statuspb)
                    .HasConstraintName("fk_apt_datbapengajuanklaim_apt_refstatuspb");
            });

            modelBuilder.Entity<AptDatbapengajuanklaimdetail>(entity =>
            {
                entity.HasKey(e => new { e.Nopbk, e.Nosjp, e.Noresep })
                    .HasName("idx_16593_pk_apt_datbapengajuanklaimdetail");

                entity.ToTable("apt_datbapengajuanklaimdetail", "dbo");

                entity.Property(e => e.Nopbk).HasColumnName("nopbk");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Noresep).HasColumnName("noresep");

                entity.Property(e => e.Bystjsjp).HasColumnName("bystjsjp");

                entity.Property(e => e.Bytagsjp).HasColumnName("bytagsjp");

                entity.Property(e => e.Byversjp).HasColumnName("byversjp");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flaguserver).HasColumnName("flaguserver");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Kdjnsobat).HasColumnName("kdjnsobat");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmpst).HasColumnName("nmpst");

                entity.Property(e => e.Nokapst).HasColumnName("nokapst");

                entity.Property(e => e.Refasalsjp).HasColumnName("refasalsjp");

                entity.Property(e => e.Statusver)
                    .HasColumnName("statusver")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Tglrsp).HasColumnName("tglrsp");

                entity.Property(e => e.Tglverpb).HasColumnName("tglverpb");

                entity.Property(e => e.Userver).HasColumnName("userver");

                entity.HasOne(d => d.NopbkNavigation)
                    .WithMany(p => p.AptDatbapengajuanklaimdetails)
                    .HasForeignKey(d => d.Nopbk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datbapengajuanklaimdetail_apt_datbapengajuanklaim");

                entity.HasOne(d => d.StatusverNavigation)
                    .WithMany(p => p.AptDatbapengajuanklaimdetails)
                    .HasForeignKey(d => d.Statusver)
                    .HasConstraintName("fk_apt_datbapengajuanklaimdetail_apt_refstatusverresep");
            });

            modelBuilder.Entity<AptDatbapengajuanklaimjenisobat>(entity =>
            {
                entity.HasKey(e => new { e.Nopbk, e.Kdjnsobat })
                    .HasName("idx_16601_pk_apt_datbapengajuanklaimjenisobat");

                entity.ToTable("apt_datbapengajuanklaimjenisobat", "dbo");

                entity.Property(e => e.Nopbk).HasColumnName("nopbk");

                entity.Property(e => e.Kdjnsobat).HasColumnName("kdjnsobat");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Jmlrsptag).HasColumnName("jmlrsptag");

                entity.Property(e => e.Jmlrspver).HasColumnName("jmlrspver");

                entity.Property(e => e.Keterangantag).HasColumnName("keterangantag");

                entity.Property(e => e.Keteranganver).HasColumnName("keteranganver");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.HasOne(d => d.NopbkNavigation)
                    .WithMany(p => p.AptDatbapengajuanklaimjenisobats)
                    .HasForeignKey(d => d.Nopbk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datbapengajuanklaimjenisobat_apt_datbapengajuanklaim");
            });

            modelBuilder.Entity<AptDatkekosonganobat>(entity =>
            {
                entity.HasKey(e => new { e.Kdppk, e.Kdobat, e.Tglsuratpemesanan })
                    .HasName("idx_16607_pk_apt_datkekosonganobat");

                entity.ToTable("apt_datkekosonganobat", "dbo");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Kdobat).HasColumnName("kdobat");

                entity.Property(e => e.Tglsuratpemesanan).HasColumnName("tglsuratpemesanan");

                entity.Property(e => e.Accountepurch).HasColumnName("accountepurch");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Jmlobat).HasColumnName("jmlobat");

                entity.Property(e => e.Kdalasankosong).HasColumnName("kdalasankosong");

                entity.Property(e => e.Kdjnsinstansi).HasColumnName("kdjnsinstansi");

                entity.Property(e => e.Kdmetodepemesanan).HasColumnName("kdmetodepemesanan");

                entity.Property(e => e.Kdpabrik).HasColumnName("kdpabrik");

                entity.Property(e => e.Kdprop).HasColumnName("kdprop");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Namadistributor).HasColumnName("namadistributor");

                entity.Property(e => e.Tglkejadian).HasColumnName("tglkejadian");

                entity.HasOne(d => d.KdalasankosongNavigation)
                    .WithMany(p => p.AptDatkekosonganobats)
                    .HasForeignKey(d => d.Kdalasankosong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datkekosonganobat_apt_refalasankosongobat");
            });

            modelBuilder.Entity<AptDatkekosonganobatNew>(entity =>
            {
                entity.ToTable("apt_datkekosonganobat_new", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accountepurch).HasColumnName("accountepurch");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Jnsapotek).HasColumnName("jnsapotek");

                entity.Property(e => e.Kdalasankosong).HasColumnName("kdalasankosong");

                entity.Property(e => e.Kdmetodepemesanan).HasColumnName("kdmetodepemesanan");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Kdprop).HasColumnName("kdprop");

                entity.Property(e => e.Ketalasankekosonganobat).HasColumnName("ketalasankekosonganobat");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Noidpemesanepurchasing).HasColumnName("noidpemesanepurchasing");

                entity.Property(e => e.Pathevidenkendala).HasColumnName("pathevidenkendala");

                entity.Property(e => e.Pathevidenlaporan).HasColumnName("pathevidenlaporan");

                entity.Property(e => e.Penyampaiankekemkeslkpp).HasColumnName("penyampaiankekemkeslkpp");

                entity.Property(e => e.Sudahadaevidenfarmasi).HasColumnName("sudahadaevidenfarmasi");

                entity.Property(e => e.Telahpesantptdkadakonfirm).HasColumnName("telahpesantptdkadakonfirm");

                entity.Property(e => e.Tglkejadian).HasColumnName("tglkejadian");

                entity.Property(e => e.Tglsuratpemesanan).HasColumnName("tglsuratpemesanan");

                entity.Property(e => e.Tindaklanjut).HasColumnName("tindaklanjut");

                entity.HasOne(d => d.KdalasankosongNavigation)
                    .WithMany(p => p.AptDatkekosonganobatNews)
                    .HasForeignKey(d => d.Kdalasankosong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datkekosonganobat_new_refalasankosongobat");
            });

            modelBuilder.Entity<AptDatkekosonganobatdetilNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_datkekosonganobatdetil_new", "dbo");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Industrifarmasi).HasColumnName("industrifarmasi");

                entity.Property(e => e.Industrifarmasilain).HasColumnName("industrifarmasilain");

                entity.Property(e => e.Jnsobat).HasColumnName("jnsobat");

                entity.Property(e => e.Kddistributorfarmasi).HasColumnName("kddistributorfarmasi");

                entity.Property(e => e.Kdgenerikobat).HasColumnName("kdgenerikobat");

                entity.Property(e => e.Kdindustrifarmasi).HasColumnName("kdindustrifarmasi");

                entity.Property(e => e.Kekuatan).HasColumnName("kekuatan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmdistributor).HasColumnName("nmdistributor");

                entity.Property(e => e.Nmdistributorlain).HasColumnName("nmdistributorlain");

                entity.Property(e => e.Nmgenerikobat).HasColumnName("nmgenerikobat");

                entity.Property(e => e.Nmpatendagangobat).HasColumnName("nmpatendagangobat");

                entity.Property(e => e.Periode).HasColumnName("periode");

                entity.Property(e => e.Sediaan).HasColumnName("sediaan");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datkekosonganobatdetil_new_apt_datkekosonganobat_new");
            });

            modelBuilder.Entity<AptDatkunjungan>(entity =>
            {
                entity.HasKey(e => e.NoKunjungan)
                    .HasName("idx_16632_pk_apt_datkunjungan");

                entity.ToTable("apt_datkunjungan", "dbo");

                entity.Property(e => e.NoKunjungan).HasColumnName("no_kunjungan");

                entity.Property(e => e.Beratbadan).HasColumnName("beratbadan");

                entity.Property(e => e.Biaya).HasColumnName("biaya");

                entity.Property(e => e.Catatankhusus).HasColumnName("catatankhusus");

                entity.Property(e => e.Diastole).HasColumnName("diastole");

                entity.Property(e => e.Dilayanirs).HasColumnName("dilayanirs");

                entity.Property(e => e.Fdate).HasColumnName("fdate");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.HeartRate).HasColumnName("heart_rate");

                entity.Property(e => e.Idsistem).HasColumnName("idsistem");

                entity.Property(e => e.KdDiagnosa).HasColumnName("kd_diagnosa");

                entity.Property(e => e.KdDiagnosa2).HasColumnName("kd_diagnosa2");

                entity.Property(e => e.KdDiagnosa3).HasColumnName("kd_diagnosa3");

                entity.Property(e => e.KdKunjungan).HasColumnName("kd_kunjungan");

                entity.Property(e => e.KdProgprolanis).HasColumnName("kd_progprolanis");

                entity.Property(e => e.Kddokter).HasColumnName("kddokter");

                entity.Property(e => e.Kdjnspst).HasColumnName("kdjnspst");

                entity.Property(e => e.Kdkc).HasColumnName("kdkc");

                entity.Property(e => e.Kdpoli).HasColumnName("kdpoli");

                entity.Property(e => e.Kdsadar).HasColumnName("kdsadar");

                entity.Property(e => e.Kdstatuspulang).HasColumnName("kdstatuspulang");

                entity.Property(e => e.Kdtagih).HasColumnName("kdtagih");

                entity.Property(e => e.Kdtkp).HasColumnName("kdtkp");

                entity.Property(e => e.Keluhan).HasColumnName("keluhan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nokapst).HasColumnName("nokapst");

                entity.Property(e => e.Pemeriksaanlain).HasColumnName("pemeriksaanlain");

                entity.Property(e => e.Pisapst).HasColumnName("pisapst");

                entity.Property(e => e.PoliRujuk).HasColumnName("poli_rujuk");

                entity.Property(e => e.PoliRujukinternal).HasColumnName("poli_rujukinternal");

                entity.Property(e => e.PpkAsalrujuk).HasColumnName("ppk_asalrujuk");

                entity.Property(e => e.PpkKunjungan).HasColumnName("ppk_kunjungan");

                entity.Property(e => e.PpkPst).HasColumnName("ppk_pst");

                entity.Property(e => e.PpkRujuk).HasColumnName("ppk_rujuk");

                entity.Property(e => e.PrbId).HasColumnName("prb_id");

                entity.Property(e => e.Refasalkunjungan).HasColumnName("refasalkunjungan");

                entity.Property(e => e.RespRate).HasColumnName("resp_rate");

                entity.Property(e => e.Rujukbalikf).HasColumnName("rujukbalikf");

                entity.Property(e => e.Rujuklanjutf).HasColumnName("rujuklanjutf");

                entity.Property(e => e.Sistole).HasColumnName("sistole");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TglKunjungan).HasColumnName("tgl_kunjungan");

                entity.Property(e => e.Tglpulang).HasColumnName("tglpulang");

                entity.Property(e => e.Tinggibadan).HasColumnName("tinggibadan");
            });

            modelBuilder.Entity<AptDatnofpk>(entity =>
            {
                entity.HasKey(e => e.Nofpk)
                    .HasName("idx_16637_pk_apt_datnofpk");

                entity.ToTable("apt_datnofpk", "dbo");

                entity.Property(e => e.Nofpk).HasColumnName("nofpk");

                entity.Property(e => e.Bulanyan).HasColumnName("bulanyan");

                entity.Property(e => e.Bystjfpk).HasColumnName("bystjfpk");

                entity.Property(e => e.Bystjobtfpk)
                    .HasColumnName("bystjobtfpk")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Bytagfpk).HasColumnName("bytagfpk");

                entity.Property(e => e.Bytagobtfpk)
                    .HasColumnName("bytagobtfpk")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Byverfpk).HasColumnName("byverfpk");

                entity.Property(e => e.Byverobtfpk)
                    .HasColumnName("byverobtfpk")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagstjfpk).HasColumnName("flagstjfpk");

                entity.Property(e => e.Iduserfpk).HasColumnName("iduserfpk");

                entity.Property(e => e.Isba)
                    .HasColumnName("isba")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Jabkepalaapt).HasColumnName("jabkepalaapt");

                entity.Property(e => e.Jmlksfpk).HasColumnName("jmlksfpk");

                entity.Property(e => e.Jmlrcdkrm).HasColumnName("jmlrcdkrm");

                entity.Property(e => e.Jmltfpk).HasColumnName("jmltfpk");

                entity.Property(e => e.Jnspelfpk).HasColumnName("jnspelfpk");

                entity.Property(e => e.Jnspstfpk).HasColumnName("jnspstfpk");

                entity.Property(e => e.Nipkepalaapt).HasColumnName("nipkepalaapt");

                entity.Property(e => e.Nippetugasapt).HasColumnName("nippetugasapt");

                entity.Property(e => e.Nipstjfpk).HasColumnName("nipstjfpk");

                entity.Property(e => e.Nmkepalaapt).HasColumnName("nmkepalaapt");

                entity.Property(e => e.Nmpetugasapt).HasColumnName("nmpetugasapt");

                entity.Property(e => e.Noba).HasColumnName("noba");

                entity.Property(e => e.Nofpkrs).HasColumnName("nofpkrs");

                entity.Property(e => e.Ppkfpk).HasColumnName("ppkfpk");

                entity.Property(e => e.Statusfpk)
                    .HasColumnName("statusfpk")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Tahunyan).HasColumnName("tahunyan");

                entity.Property(e => e.Tgljthtempo).HasColumnName("tgljthtempo");

                entity.Property(e => e.Tglkrmfpk).HasColumnName("tglkrmfpk");

                entity.Property(e => e.Tglnofpk).HasColumnName("tglnofpk");

                entity.Property(e => e.Tglpengajuan).HasColumnName("tglpengajuan");

                entity.Property(e => e.Tglstjfpk).HasColumnName("tglstjfpk");

                entity.Property(e => e.Userfpk).HasColumnName("userfpk");

                entity.Property(e => e.Useridstjfpk).HasColumnName("useridstjfpk");
            });

            modelBuilder.Entity<AptDatnofpkHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_datnofpk_hist", "dbo");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Nofpk).HasColumnName("nofpk");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<AptDatobat>(entity =>
            {
                entity.HasKey(e => new { e.Nosjp, e.Noresep, e.Jnsrobt, e.Kdobt })
                    .HasName("idx_16654_pk_apt_datobat");

                entity.ToTable("apt_datobat", "dbo");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Noresep).HasColumnName("noresep");

                entity.Property(e => e.Jnsrobt).HasColumnName("jnsrobt");

                entity.Property(e => e.Kdobt).HasColumnName("kdobt");

                entity.Property(e => e.Alasanobt).HasColumnName("alasanobt");

                entity.Property(e => e.Catkhsobt).HasColumnName("catkhsobt");

                entity.Property(e => e.Catkhsobtver).HasColumnName("catkhsobtver");

                entity.Property(e => e.Faktor).HasColumnName("faktor");

                entity.Property(e => e.Faktorndpho).HasColumnName("faktorndpho");

                entity.Property(e => e.Faktorver).HasColumnName("faktorver");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagcobt).HasColumnName("flagcobt");

                entity.Property(e => e.Flagtanggung).HasColumnName("flagtanggung");

                entity.Property(e => e.Flagvobt).HasColumnName("flagvobt");

                entity.Property(e => e.Hdasar).HasColumnName("hdasar");

                entity.Property(e => e.Hdasarndpho).HasColumnName("hdasarndpho");

                entity.Property(e => e.Hdasarver).HasColumnName("hdasarver");

                entity.Property(e => e.Hrgstjobt)
                    .HasColumnName("hrgstjobt")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Hrgtagobt)
                    .HasColumnName("hrgtagobt")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Hrgverobt)
                    .HasColumnName("hrgverobt")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Jho).HasColumnName("jho");

                entity.Property(e => e.Jhover).HasColumnName("jhover");

                entity.Property(e => e.Jmlobt).HasColumnName("jmlobt");

                entity.Property(e => e.Jmlobtr).HasColumnName("jmlobtr");

                entity.Property(e => e.Jmlobtrver).HasColumnName("jmlobtrver");

                entity.Property(e => e.Jmlobtver).HasColumnName("jmlobtver");

                entity.Property(e => e.Kdobtver).HasColumnName("kdobtver");

                entity.Property(e => e.Kekuatan).HasColumnName("kekuatan");

                entity.Property(e => e.Kekuatanver).HasColumnName("kekuatanver");

                entity.Property(e => e.Nmobatndpho).HasColumnName("nmobatndpho");

                entity.Property(e => e.Nokonf).HasColumnName("nokonf");

                entity.Property(e => e.Permintaan).HasColumnName("permintaan");

                entity.Property(e => e.Permintaanver).HasColumnName("permintaanver");

                entity.Property(e => e.Sediandpho).HasColumnName("sediandpho");

                entity.Property(e => e.Serviceobt).HasColumnName("serviceobt");

                entity.Property(e => e.Servicever).HasColumnName("servicever");

                entity.Property(e => e.Signa1obt).HasColumnName("signa1obt");

                entity.Property(e => e.Signa1ver).HasColumnName("signa1ver");

                entity.Property(e => e.Signa2obt).HasColumnName("signa2obt");

                entity.Property(e => e.Signa2ver).HasColumnName("signa2ver");

                entity.HasOne(d => d.KdobtNavigation)
                    .WithMany(p => p.AptDatobats)
                    .HasForeignKey(d => d.Kdobt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datobat_apt_refdpho");
            });

            modelBuilder.Entity<AptDatresep>(entity =>
            {
                entity.HasKey(e => new { e.Nosjp, e.Noresep })
                    .HasName("idx_16663_pk_apt_datresep");

                entity.ToTable("apt_datresep", "dbo");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Noresep).HasColumnName("noresep");

                entity.Property(e => e.Bystjrsp)
                    .HasColumnName("bystjrsp")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Bytagrsp)
                    .HasColumnName("bytagrsp")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Byverrsp)
                    .HasColumnName("byverrsp")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Flagkirim)
                    .HasColumnName("flagkirim")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Flagtirsp).HasColumnName("flagtirsp");

                entity.Property(e => e.Kddokter).HasColumnName("kddokter");

                entity.Property(e => e.Nmdokter).HasColumnName("nmdokter");

                entity.Property(e => e.Noresepapt).HasColumnName("noresepapt");

                entity.Property(e => e.Polirsp).HasColumnName("polirsp");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'0'::text");

                entity.Property(e => e.Statuspb)
                    .HasColumnName("statuspb")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Tglkirim).HasColumnName("tglkirim");

                entity.Property(e => e.Tglpelrsp).HasColumnName("tglpelrsp");

                entity.Property(e => e.Tglrsp).HasColumnName("tglrsp");

                entity.Property(e => e.Tglver).HasColumnName("tglver");

                entity.Property(e => e.Tkprsp).HasColumnName("tkprsp");

                entity.Property(e => e.Upfrsp).HasColumnName("upfrsp");

                entity.Property(e => e.Useridver).HasColumnName("useridver");

                entity.HasOne(d => d.NosjpNavigation)
                    .WithMany(p => p.AptDatreseps)
                    .HasForeignKey(d => d.Nosjp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datresep_apt_datsjp");
            });

            modelBuilder.Entity<AptDatsepapprexpr>(entity =>
            {
                entity.HasKey(e => e.Nosep)
                    .HasName("idx_16674_pk_apt_datsepapprexpr");

                entity.ToTable("apt_datsepapprexpr", "dbo");

                entity.Property(e => e.Nosep).HasColumnName("nosep");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Kdppkapotek).HasColumnName("kdppkapotek");

                entity.Property(e => e.Kdppkpelsep).HasColumnName("kdppkpelsep");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Tglappr).HasColumnName("tglappr");

                entity.Property(e => e.Tglpengajuan)
                    .HasColumnName("tglpengajuan")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Tglplgsep).HasColumnName("tglplgsep");
            });

            modelBuilder.Entity<AptDatsepiterasi>(entity =>
            {
                entity.HasKey(e => e.Refasalsjp)
                    .HasName("idx_16682_pk__apt_dats__108fb698a1d75308");

                entity.ToTable("apt_datsepiterasi", "dbo");

                entity.Property(e => e.Refasalsjp).HasColumnName("refasalsjp");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Iterasi).HasColumnName("iterasi");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");
            });

            modelBuilder.Entity<AptDatsjp>(entity =>
            {
                entity.HasKey(e => e.Nosjp)
                    .HasName("idx_16688_pk_datsjpapt");

                entity.ToTable("apt_datsjp", "dbo");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Bystjobtsjp)
                    .HasColumnName("bystjobtsjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Bystjsjp)
                    .HasColumnName("bystjsjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Bytagobtsjp)
                    .HasColumnName("bytagobtsjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Bytagsjp)
                    .HasColumnName("bytagsjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Byverobtsjp)
                    .HasColumnName("byverobtsjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Byversjp)
                    .HasColumnName("byversjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Catkhssjp).HasColumnName("catkhssjp");

                entity.Property(e => e.Diagppk).HasColumnName("diagppk");

                entity.Property(e => e.Diagrs).HasColumnName("diagrs");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagakhirsjp).HasColumnName("flagakhirsjp");

                entity.Property(e => e.Flagasaldata)
                    .HasColumnName("flagasaldata")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Flagasalrspkunjrs).HasColumnName("flagasalrspkunjrs");

                entity.Property(e => e.Flagentrysjp).HasColumnName("flagentrysjp");

                entity.Property(e => e.Flagiter).HasColumnName("flagiter");

                entity.Property(e => e.Flaglpstsjp).HasColumnName("flaglpstsjp");

                entity.Property(e => e.Flagprsklaimsjp).HasColumnName("flagprsklaimsjp");

                entity.Property(e => e.Flagpstrs)
                    .HasColumnName("flagpstrs")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Flagrrwt).HasColumnName("flagrrwt");

                entity.Property(e => e.Idusersjp).HasColumnName("idusersjp");

                entity.Property(e => e.Issepoffline)
                    .HasColumnName("issepoffline")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Jmlkssjp)
                    .HasColumnName("jmlkssjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Jmltsjp)
                    .HasColumnName("jmltsjp")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Jnspelsjp).HasColumnName("jnspelsjp");

                entity.Property(e => e.Kdjnsobat).HasColumnName("kdjnsobat");

                entity.Property(e => e.Kdjnspeserta).HasColumnName("kdjnspeserta");

                entity.Property(e => e.Kdpks).HasColumnName("kdpks");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Mrpstsjp).HasColumnName("mrpstsjp");

                entity.Property(e => e.Namastjrs).HasColumnName("namastjrs");

                entity.Property(e => e.Nipstjkasie).HasColumnName("nipstjkasie");

                entity.Property(e => e.Nipstjsjp).HasColumnName("nipstjsjp");

                entity.Property(e => e.Nocetak).HasColumnName("nocetak");

                entity.Property(e => e.Nofpk).HasColumnName("nofpk");

                entity.Property(e => e.Nokapst).HasColumnName("nokapst");

                entity.Property(e => e.Norjkawalsjp).HasColumnName("norjkawalsjp");

                entity.Property(e => e.Pisapst).HasColumnName("pisapst");

                entity.Property(e => e.Politujsjp).HasColumnName("politujsjp");

                entity.Property(e => e.Ppkpelsjp).HasColumnName("ppkpelsjp");

                entity.Property(e => e.Ppkrjkawalsjp).HasColumnName("ppkrjkawalsjp");

                entity.Property(e => e.Refasalsjp).HasColumnName("refasalsjp");

                entity.Property(e => e.Tgldtgsjp).HasColumnName("tgldtgsjp");

                entity.Property(e => e.Tglplgsjp).HasColumnName("tglplgsjp");

                entity.Property(e => e.Tglrjkawalsjp).HasColumnName("tglrjkawalsjp");

                entity.Property(e => e.Tglsjp).HasColumnName("tglsjp");

                entity.Property(e => e.Tglstjkasie).HasColumnName("tglstjkasie");

                entity.Property(e => e.Tglstjrs).HasColumnName("tglstjrs");

                entity.Property(e => e.Tglversjp).HasColumnName("tglversjp");

                entity.Property(e => e.Tstamp)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("tstamp");

                entity.HasOne(d => d.JnspelsjpNavigation)
                    .WithMany(p => p.AptDatsjps)
                    .HasForeignKey(d => d.Jnspelsjp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_datsjp_apt_refjnspelsjp");

                entity.HasOne(d => d.NofpkNavigation)
                    .WithMany(p => p.AptDatsjps)
                    .HasForeignKey(d => d.Nofpk)
                    .HasConstraintName("fk_apt_datsjp_apt_datnofpk");
            });

            modelBuilder.Entity<AptHistupdDatobat>(entity =>
            {
                entity.HasKey(e => new { e.Nosjp, e.Noresep, e.Jnsrobt, e.Kdobt })
                    .HasName("idx_16705_pk_apt_histupd_datobat");

                entity.ToTable("apt_histupd_datobat", "dbo");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Noresep).HasColumnName("noresep");

                entity.Property(e => e.Jnsrobt).HasColumnName("jnsrobt");

                entity.Property(e => e.Kdobt).HasColumnName("kdobt");

                entity.Property(e => e.Alasanobt).HasColumnName("alasanobt");

                entity.Property(e => e.Catkhsobt).HasColumnName("catkhsobt");

                entity.Property(e => e.Catkhsobtver).HasColumnName("catkhsobtver");

                entity.Property(e => e.Faktor).HasColumnName("faktor");

                entity.Property(e => e.Faktorndpho).HasColumnName("faktorndpho");

                entity.Property(e => e.Faktorver).HasColumnName("faktorver");

                entity.Property(e => e.Fdate).HasColumnName("fdate");

                entity.Property(e => e.Fdatehist)
                    .HasColumnName("fdatehist")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagcobt).HasColumnName("flagcobt");

                entity.Property(e => e.Flagtanggung).HasColumnName("flagtanggung");

                entity.Property(e => e.Flagvobt).HasColumnName("flagvobt");

                entity.Property(e => e.Hdasar).HasColumnName("hdasar");

                entity.Property(e => e.Hdasarndpho).HasColumnName("hdasarndpho");

                entity.Property(e => e.Hdasarver).HasColumnName("hdasarver");

                entity.Property(e => e.Hrgstjobt).HasColumnName("hrgstjobt");

                entity.Property(e => e.Hrgtagobt).HasColumnName("hrgtagobt");

                entity.Property(e => e.Hrgverobt).HasColumnName("hrgverobt");

                entity.Property(e => e.Jho).HasColumnName("jho");

                entity.Property(e => e.Jhover).HasColumnName("jhover");

                entity.Property(e => e.Jmlobt).HasColumnName("jmlobt");

                entity.Property(e => e.Jmlobtr).HasColumnName("jmlobtr");

                entity.Property(e => e.Jmlobtrver).HasColumnName("jmlobtrver");

                entity.Property(e => e.Jmlobtver).HasColumnName("jmlobtver");

                entity.Property(e => e.Kdobtver).HasColumnName("kdobtver");

                entity.Property(e => e.Kekuatan).HasColumnName("kekuatan");

                entity.Property(e => e.Kekuatanver).HasColumnName("kekuatanver");

                entity.Property(e => e.Nmobatndpho).HasColumnName("nmobatndpho");

                entity.Property(e => e.Nokonf).HasColumnName("nokonf");

                entity.Property(e => e.Permintaan).HasColumnName("permintaan");

                entity.Property(e => e.Permintaanver).HasColumnName("permintaanver");

                entity.Property(e => e.Sediandpho).HasColumnName("sediandpho");

                entity.Property(e => e.Serviceobt).HasColumnName("serviceobt");

                entity.Property(e => e.Servicever).HasColumnName("servicever");

                entity.Property(e => e.Signa1obt).HasColumnName("signa1obt");

                entity.Property(e => e.Signa1ver).HasColumnName("signa1ver");

                entity.Property(e => e.Signa2obt).HasColumnName("signa2obt");

                entity.Property(e => e.Signa2ver).HasColumnName("signa2ver");
            });

            modelBuilder.Entity<AptHistupdDatresep>(entity =>
            {
                entity.HasKey(e => new { e.Nosjp, e.Noresep })
                    .HasName("idx_16711_pk_apt_histupd_datresep");

                entity.ToTable("apt_histupd_datresep", "dbo");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Noresep).HasColumnName("noresep");

                entity.Property(e => e.Bystjrsp)
                    .HasColumnName("bystjrsp")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Bytagrsp)
                    .HasColumnName("bytagrsp")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Byverrsp)
                    .HasColumnName("byverrsp")
                    .HasDefaultValueSql("'0'::double precision");

                entity.Property(e => e.Fdatehist)
                    .HasColumnName("fdatehist")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagkirim)
                    .HasColumnName("flagkirim")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Flagtirsp).HasColumnName("flagtirsp");

                entity.Property(e => e.Kddokter).HasColumnName("kddokter");

                entity.Property(e => e.Nmdokter).HasColumnName("nmdokter");

                entity.Property(e => e.Noresepapt).HasColumnName("noresepapt");

                entity.Property(e => e.Polirsp).HasColumnName("polirsp");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'0'::text");

                entity.Property(e => e.Statuspb)
                    .HasColumnName("statuspb")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Tglkirim).HasColumnName("tglkirim");

                entity.Property(e => e.Tglpelrsp).HasColumnName("tglpelrsp");

                entity.Property(e => e.Tglrsp).HasColumnName("tglrsp");

                entity.Property(e => e.Tglver).HasColumnName("tglver");

                entity.Property(e => e.Tkprsp).HasColumnName("tkprsp");

                entity.Property(e => e.Upfrsp).HasColumnName("upfrsp");

                entity.Property(e => e.Useridver).HasColumnName("useridver");
            });

            modelBuilder.Entity<AptHistupdDatsjp>(entity =>
            {
                entity.HasKey(e => e.Nosjp)
                    .HasName("idx_16723_pk_apt_histupd_datsjp");

                entity.ToTable("apt_histupd_datsjp", "dbo");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Bystjobtsjp).HasColumnName("bystjobtsjp");

                entity.Property(e => e.Bystjsjp).HasColumnName("bystjsjp");

                entity.Property(e => e.Bytagobtsjp).HasColumnName("bytagobtsjp");

                entity.Property(e => e.Bytagsjp).HasColumnName("bytagsjp");

                entity.Property(e => e.Byverobtsjp).HasColumnName("byverobtsjp");

                entity.Property(e => e.Byversjp).HasColumnName("byversjp");

                entity.Property(e => e.Catkhssjp).HasColumnName("catkhssjp");

                entity.Property(e => e.Diagppk).HasColumnName("diagppk");

                entity.Property(e => e.Diagrs).HasColumnName("diagrs");

                entity.Property(e => e.Fdate).HasColumnName("fdate");

                entity.Property(e => e.Fdatehist)
                    .HasColumnName("fdatehist")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagakhirsjp).HasColumnName("flagakhirsjp");

                entity.Property(e => e.Flagasaldata).HasColumnName("flagasaldata");

                entity.Property(e => e.Flagasalrspkunjrs).HasColumnName("flagasalrspkunjrs");

                entity.Property(e => e.Flagentrysjp).HasColumnName("flagentrysjp");

                entity.Property(e => e.Flagiter).HasColumnName("flagiter");

                entity.Property(e => e.Flaglpstsjp).HasColumnName("flaglpstsjp");

                entity.Property(e => e.Flagprsklaimsjp).HasColumnName("flagprsklaimsjp");

                entity.Property(e => e.Flagpstrs).HasColumnName("flagpstrs");

                entity.Property(e => e.Flagrrwt).HasColumnName("flagrrwt");

                entity.Property(e => e.Idusersjp).HasColumnName("idusersjp");

                entity.Property(e => e.Issepoffline).HasColumnName("issepoffline");

                entity.Property(e => e.Jmlkssjp).HasColumnName("jmlkssjp");

                entity.Property(e => e.Jmltsjp).HasColumnName("jmltsjp");

                entity.Property(e => e.Jnspelsjp).HasColumnName("jnspelsjp");

                entity.Property(e => e.Kdjnsobat).HasColumnName("kdjnsobat");

                entity.Property(e => e.Kdjnspeserta).HasColumnName("kdjnspeserta");

                entity.Property(e => e.Kdpks).HasColumnName("kdpks");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Mrpstsjp).HasColumnName("mrpstsjp");

                entity.Property(e => e.Namastjrs).HasColumnName("namastjrs");

                entity.Property(e => e.Nipstjkasie).HasColumnName("nipstjkasie");

                entity.Property(e => e.Nipstjsjp).HasColumnName("nipstjsjp");

                entity.Property(e => e.Nocetak).HasColumnName("nocetak");

                entity.Property(e => e.Nofpk).HasColumnName("nofpk");

                entity.Property(e => e.Nokapst).HasColumnName("nokapst");

                entity.Property(e => e.Norjkawalsjp).HasColumnName("norjkawalsjp");

                entity.Property(e => e.Pisapst).HasColumnName("pisapst");

                entity.Property(e => e.Politujsjp).HasColumnName("politujsjp");

                entity.Property(e => e.Ppkpelsjp).HasColumnName("ppkpelsjp");

                entity.Property(e => e.Ppkrjkawalsjp).HasColumnName("ppkrjkawalsjp");

                entity.Property(e => e.Refasalsjp).HasColumnName("refasalsjp");

                entity.Property(e => e.Tgldtgsjp).HasColumnName("tgldtgsjp");

                entity.Property(e => e.Tglplgsjp).HasColumnName("tglplgsjp");

                entity.Property(e => e.Tglrjkawalsjp).HasColumnName("tglrjkawalsjp");

                entity.Property(e => e.Tglsjp).HasColumnName("tglsjp");

                entity.Property(e => e.Tglstjkasie).HasColumnName("tglstjkasie");

                entity.Property(e => e.Tglstjrs).HasColumnName("tglstjrs");

                entity.Property(e => e.Tglversjp).HasColumnName("tglversjp");
            });

            modelBuilder.Entity<AptLogdownload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_logdownload", "dbo");

                entity.Property(e => e.Controller).HasColumnName("controller");

                entity.Property(e => e.Ip).HasColumnName("ip");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Metode).HasColumnName("metode");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Waktu)
                    .HasColumnName("waktu")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<AptLoguser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("idx_16735_pk__apt_logu__1788cc4c7955fcbb");

                entity.ToTable("apt_loguser", "dbo");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Clientip).HasColumnName("clientip");

                entity.Property(e => e.Hostname).HasColumnName("hostname");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Lastactivity).HasColumnName("lastactivity");

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Lastlogout).HasColumnName("lastlogout");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            modelBuilder.Entity<AptMtmDatgroupmasalah>(entity =>
            {
                entity.HasKey(e => new { e.Nomtm, e.Idgroupmasalah })
                    .HasName("idx_16742_pk_apt_mtm_datgroupmasalah");

                entity.ToTable("apt_mtm_datgroupmasalah", "dbo");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");

                entity.Property(e => e.Idgroupmasalah).HasColumnName("idgroupmasalah");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.HasOne(d => d.NomtmNavigation)
                    .WithMany(p => p.AptMtmDatgroupmasalahs)
                    .HasForeignKey(d => d.Nomtm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_mtm_datgroupmasalah_apt_mtm_datmtm");
            });

            modelBuilder.Entity<AptMtmDatketercapaiantarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_mtm_datketercapaiantarget", "dbo");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Idketercapaiantarget).HasColumnName("idketercapaiantarget");

                entity.Property(e => e.Idtargetpengobatan).HasColumnName("idtargetpengobatan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");
            });

            modelBuilder.Entity<AptMtmDatmasalah>(entity =>
            {
                entity.HasKey(e => new { e.Nomtm, e.Idmasalah })
                    .HasName("idx_16754_pk_apt_mtm_datmasalah");

                entity.ToTable("apt_mtm_datmasalah", "dbo");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");

                entity.Property(e => e.Idmasalah).HasColumnName("idmasalah");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.HasOne(d => d.IdmasalahNavigation)
                    .WithMany(p => p.AptMtmDatmasalahs)
                    .HasForeignKey(d => d.Idmasalah)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_mtm_datmasalah_apt_mtm_refmasalah");

                entity.HasOne(d => d.NomtmNavigation)
                    .WithMany(p => p.AptMtmDatmasalahs)
                    .HasForeignKey(d => d.Nomtm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_mtm_datmasalah_apt_mtm_datmtm");
            });

            modelBuilder.Entity<AptMtmDatmtm>(entity =>
            {
                entity.HasKey(e => e.Nomtm)
                    .HasName("idx_16760_pk__apt_mtm___05a6e2c0a6312205");

                entity.ToTable("apt_mtm_datmtm", "dbo");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagmtm).HasColumnName("flagmtm");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nohp).HasColumnName("nohp");

                entity.Property(e => e.Nosjp).HasColumnName("nosjp");

                entity.Property(e => e.Tglmtm)
                    .HasColumnName("tglmtm")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<AptMtmDatobat>(entity =>
            {
                entity.HasKey(e => new { e.Nomtm, e.Idgroupmasalah, e.Kdobat })
                    .HasName("idx_16768_pk_apt_mtm_datobat");

                entity.ToTable("apt_mtm_datobat", "dbo");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");

                entity.Property(e => e.Idgroupmasalah).HasColumnName("idgroupmasalah");

                entity.Property(e => e.Kdobat).HasColumnName("kdobat");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmobat).HasColumnName("nmobat");

                entity.HasOne(d => d.IdgroupmasalahNavigation)
                    .WithMany(p => p.AptMtmDatobats)
                    .HasForeignKey(d => d.Idgroupmasalah)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_mtm_datobat_apt_mtm_refgroupmasalah");
            });

            modelBuilder.Entity<AptMtmDatriwayatkesehatan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_mtm_datriwayatkesehatan", "dbo");

                entity.Property(e => e.Fdate).HasColumnName("fdate");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Idalergiefek).HasColumnName("idalergiefek");

                entity.Property(e => e.Idalergiobat).HasColumnName("idalergiobat");

                entity.Property(e => e.Idalergiobattambahan).HasColumnName("idalergiobattambahan");

                entity.Property(e => e.Idalergirokok).HasColumnName("idalergirokok");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");
            });

            modelBuilder.Entity<AptMtmDattargetpengobatan>(entity =>
            {
                entity.HasKey(e => new { e.Nomtm, e.Idtargetpengobatan })
                    .HasName("idx_16779_pk__apt_mtm___12fa04d8d768f3ca");

                entity.ToTable("apt_mtm_dattargetpengobatan", "dbo");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");

                entity.Property(e => e.Idtargetpengobatan).HasColumnName("idtargetpengobatan");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");
            });

            modelBuilder.Entity<AptMtmDattindaklanjutpengobatan>(entity =>
            {
                entity.HasKey(e => new { e.Nomtm, e.Idtargetpengobatan, e.Idtindaklanjutpengobatan })
                    .HasName("idx_16785_pk__apt_mtm___d06823b85b3419d5");

                entity.ToTable("apt_mtm_dattindaklanjutpengobatan", "dbo");

                entity.Property(e => e.Nomtm).HasColumnName("nomtm");

                entity.Property(e => e.Idtargetpengobatan).HasColumnName("idtargetpengobatan");

                entity.Property(e => e.Idtindaklanjutpengobatan).HasColumnName("idtindaklanjutpengobatan");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");
            });

            modelBuilder.Entity<AptMtmRefalergi>(entity =>
            {
                entity.HasKey(e => e.Idrefalergi)
                    .HasName("idx_16791_pk__apt_mtm___9d3e9b5c29284bce");

                entity.ToTable("apt_mtm_refalergi", "dbo");

                entity.Property(e => e.Idrefalergi).HasColumnName("idrefalergi");

                entity.Property(e => e.Fdate).HasColumnName("fdate");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmalergi).HasColumnName("nmalergi");
            });

            modelBuilder.Entity<AptMtmRefgroupmasalah>(entity =>
            {
                entity.HasKey(e => e.Idgroupmasalah)
                    .HasName("idx_16796_pk__apt_mtm___48f070dd1b2d2299");

                entity.ToTable("apt_mtm_refgroupmasalah", "dbo");

                entity.Property(e => e.Idgroupmasalah).HasColumnName("idgroupmasalah");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagaktif)
                    .HasColumnName("flagaktif")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmgroupmasalah).HasColumnName("nmgroupmasalah");
            });

            modelBuilder.Entity<AptMtmRefmasalah>(entity =>
            {
                entity.HasKey(e => e.Idmasalah)
                    .HasName("idx_16803_pk__apt_mtm___623b3ecc0fd9aae4");

                entity.ToTable("apt_mtm_refmasalah", "dbo");

                entity.Property(e => e.Idmasalah).HasColumnName("idmasalah");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagaktif)
                    .IsRequired()
                    .HasColumnName("flagaktif")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Idgroupmasalah).HasColumnName("idgroupmasalah");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmmasalah).HasColumnName("nmmasalah");

                entity.HasOne(d => d.IdgroupmasalahNavigation)
                    .WithMany(p => p.AptMtmRefmasalahs)
                    .HasForeignKey(d => d.Idgroupmasalah)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apt_mtm_refmasalah_apt_mtm_refgroupmasalah");
            });

            modelBuilder.Entity<AptMtmReftargetpengobatan>(entity =>
            {
                entity.HasKey(e => e.Idtargetpengobatan)
                    .HasName("idx_16811_pk__apt_mtm___75ce6180f1696efe");

                entity.ToTable("apt_mtm_reftargetpengobatan", "dbo");

                entity.Property(e => e.Idtargetpengobatan).HasColumnName("idtargetpengobatan");

                entity.Property(e => e.Fdate).HasColumnName("fdate");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmtargetpengobatan).HasColumnName("nmtargetpengobatan");
            });

            modelBuilder.Entity<AptMtmReftindaklanjutpengobatan>(entity =>
            {
                entity.HasKey(e => e.Idtindaklanjutpengobatan)
                    .HasName("idx_16818_pk__apt_mtm___922760c35906c1b8");

                entity.ToTable("apt_mtm_reftindaklanjutpengobatan", "dbo");

                entity.Property(e => e.Idtindaklanjutpengobatan).HasColumnName("idtindaklanjutpengobatan");

                entity.Property(e => e.Fdate).HasColumnName("fdate");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmtindaklanjutpengobatan).HasColumnName("nmtindaklanjutpengobatan");
            });

            modelBuilder.Entity<AptMutasiStok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_mutasi_stok", "dbo");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Jmlobat)
                    .HasColumnName("jmlobat")
                    .HasDefaultValueSql("'0'::numeric");

                entity.Property(e => e.Kdjnsmutasi).HasColumnName("kdjnsmutasi");

                entity.Property(e => e.Kdobat).HasColumnName("kdobat");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Tglmutasi).HasColumnName("tglmutasi");
            });

            modelBuilder.Entity<AptObatlkpp>(entity =>
            {
                entity.HasKey(e => e.Idobat)
                    .HasName("idx_16831_pk__apt_obat__80342a6e6cea22fb");

                entity.ToTable("apt_obatlkpp", "dbo");

                entity.Property(e => e.Idobat).HasColumnName("idobat");

                entity.Property(e => e.Dagang).HasColumnName("dagang");

                entity.Property(e => e.Edisifornas).HasColumnName("edisifornas");

                entity.Property(e => e.Edisilkpp).HasColumnName("edisilkpp");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Idfornas).HasColumnName("idfornas");

                entity.Property(e => e.Kdjnsobat).HasColumnName("kdjnsobat");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Noproduklkpp).HasColumnName("noproduklkpp");

                entity.Property(e => e.Pabrik).HasColumnName("pabrik");

                entity.Property(e => e.Tat).HasColumnName("tat");

                entity.Property(e => e.Tmt).HasColumnName("tmt");
            });

            modelBuilder.Entity<AptRefalasankosongobat>(entity =>
            {
                entity.HasKey(e => e.Kdalasankosong)
                    .HasName("idx_16837_pk_refalasankosongobat");

                entity.ToTable("apt_refalasankosongobat", "dbo");

                entity.Property(e => e.Kdalasankosong).HasColumnName("kdalasankosong");

                entity.Property(e => e.Flagaktif)
                    .HasColumnName("flagaktif")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Nmalasankosong).HasColumnName("nmalasankosong");
            });

            modelBuilder.Entity<AptRefasalsepApproval>(entity =>
            {
                entity.HasKey(e => e.Nosep)
                    .HasName("idx_16843_pk_apt_refasalsep_approval");

                entity.ToTable("apt_refasalsep_approval", "dbo");

                entity.Property(e => e.Nosep).HasColumnName("nosep");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagappr)
                    .HasColumnName("flagappr")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Jnspelsep).HasColumnName("jnspelsep");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nmpst).HasColumnName("nmpst");

                entity.Property(e => e.Nokapst).HasColumnName("nokapst");

                entity.Property(e => e.Ppkpelrsp).HasColumnName("ppkpelrsp");

                entity.Property(e => e.Tglaju).HasColumnName("tglaju");

                entity.Property(e => e.Tglappr).HasColumnName("tglappr");

                entity.Property(e => e.Tglsep).HasColumnName("tglsep");

                entity.Property(e => e.Useridaju).HasColumnName("useridaju");

                entity.Property(e => e.Useridappr).HasColumnName("useridappr");
            });

            modelBuilder.Entity<AptRefdpho>(entity =>
            {
                entity.HasKey(e => e.Kdobat)
                    .HasName("idx_16850_pk_apt_refdpho");

                entity.ToTable("apt_refdpho", "dbo");

                entity.Property(e => e.Kdobat).HasColumnName("kdobat");

                entity.Property(e => e.Atccode).HasColumnName("atccode");

                entity.Property(e => e.Dagang).HasColumnName("dagang");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Generik).HasColumnName("generik");

                entity.Property(e => e.Hdasar).HasColumnName("hdasar");

                entity.Property(e => e.Hdiff)
                    .HasColumnName("hdiff")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Hmax)
                    .HasColumnName("hmax")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Jnsobt).HasColumnName("jnsobt");

                entity.Property(e => e.Kdekatalog).HasColumnName("kdekatalog");

                entity.Property(e => e.Kdfaktor).HasColumnName("kdfaktor");

                entity.Property(e => e.Kdjnsobat).HasColumnName("kdjnsobat");

                entity.Property(e => e.Kdprop).HasColumnName("kdprop");

                entity.Property(e => e.Kekuatan).HasColumnName("kekuatan");

                entity.Property(e => e.Klsterapi).HasColumnName("klsterapi");

                entity.Property(e => e.Kodegenerik).HasColumnName("kodegenerik");

                entity.Property(e => e.Kuat).HasColumnName("kuat");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Lmax)
                    .HasColumnName("lmax")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Obat).HasColumnName("obat");

                entity.Property(e => e.Pabrik).HasColumnName("pabrik");

                entity.Property(e => e.Restriksi).HasColumnName("restriksi");

                entity.Property(e => e.Rmax)
                    .HasColumnName("rmax")
                    .HasDefaultValueSql("'0'::smallint");

                entity.Property(e => e.Satuan).HasColumnName("satuan");

                entity.Property(e => e.Sedia).HasColumnName("sedia");

                entity.Property(e => e.Sediaan).HasColumnName("sediaan");

                entity.Property(e => e.Signa1).HasColumnName("signa1");

                entity.Property(e => e.Signa2).HasColumnName("signa2");

                entity.Property(e => e.Sub2kls).HasColumnName("sub2kls");

                entity.Property(e => e.Subkls).HasColumnName("subkls");

                entity.Property(e => e.Tglakhir)
                    .HasColumnName("tglakhir")
                    .HasDefaultValueSql("'9999-12-31 00:00:00+07'::timestamp with time zone");

                entity.Property(e => e.Tglmulai).HasColumnName("tglmulai");

                entity.Property(e => e.Tgltayang)
                    .HasColumnName("tgltayang")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<AptReffiltrasitkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_reffiltrasitkp", "dbo");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagaktif)
                    .HasColumnName("flagaktif")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Idfiltrasi).HasColumnName("idfiltrasi");

                entity.Property(e => e.Kdtkp).HasColumnName("kdtkp");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");
            });

            modelBuilder.Entity<AptRefharitanggungan>(entity =>
            {
                entity.HasKey(e => new { e.Kdppk, e.Tglmulai })
                    .HasName("idx_16869_pk_apt_refharitanggungan");

                entity.ToTable("apt_refharitanggungan", "dbo");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Tglmulai).HasColumnName("tglmulai");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Hkemo).HasColumnName("hkemo");

                entity.Property(e => e.Hkronis).HasColumnName("hkronis");

                entity.Property(e => e.Hkronisrs).HasColumnName("hkronisrs");

                entity.Property(e => e.Hprb).HasColumnName("hprb");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Tglakhir).HasColumnName("tglakhir");
            });

            modelBuilder.Entity<AptRefharitanggunganHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("apt_refharitanggungan_hist", "dbo");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Hkemo).HasColumnName("hkemo");

                entity.Property(e => e.Hkronis).HasColumnName("hkronis");

                entity.Property(e => e.Hkronisrs).HasColumnName("hkronisrs");

                entity.Property(e => e.Hprb).HasColumnName("hprb");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Tglakhir).HasColumnName("tglakhir");

                entity.Property(e => e.Tglmulai).HasColumnName("tglmulai");
            });

            modelBuilder.Entity<AptRefjnsfiltrasi>(entity =>
            {
                entity.HasKey(e => e.Idfiltrasi)
                    .HasName("idx_16881_pk_apt_refjnsfiltrasi");

                entity.ToTable("apt_refjnsfiltrasi", "dbo");

                entity.Property(e => e.Idfiltrasi).HasColumnName("idfiltrasi");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagaktif)
                    .HasColumnName("flagaktif")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");
            });

            modelBuilder.Entity<AptRefjnspelsjp>(entity =>
            {
                entity.HasKey(e => e.Jnspelsjp)
                    .HasName("idx_16888_pk_apt_refjnspelsjp");

                entity.ToTable("apt_refjnspelsjp", "dbo");

                entity.Property(e => e.Jnspelsjp).HasColumnName("jnspelsjp");

                entity.Property(e => e.Flagaktif)
                    .HasColumnName("flagaktif")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Nmjnspelsjp).HasColumnName("nmjnspelsjp");
            });

            modelBuilder.Entity<AptRefsettingppk>(entity =>
            {
                entity.HasKey(e => e.Kdppk)
                    .HasName("idx_16894_pk_apt_refsettingppk");

                entity.ToTable("apt_refsettingppk", "dbo");

                entity.Property(e => e.Kdppk).HasColumnName("kdppk");

                entity.Property(e => e.Alamat).HasColumnName("alamat");

                entity.Property(e => e.Checkstock).HasColumnName("checkstock");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Jabkepala).HasColumnName("jabkepala");

                entity.Property(e => e.Kota).HasColumnName("kota");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");

                entity.Property(e => e.Nipkepala).HasColumnName("nipkepala");

                entity.Property(e => e.Nippetugasapt).HasColumnName("nippetugasapt");

                entity.Property(e => e.Nmapoteker).HasColumnName("nmapoteker");

                entity.Property(e => e.Nmkepala).HasColumnName("nmkepala");

                entity.Property(e => e.Nmpetugasapt).HasColumnName("nmpetugasapt");

                entity.Property(e => e.Nmverifikator).HasColumnName("nmverifikator");

                entity.Property(e => e.Nppverifikator).HasColumnName("nppverifikator");

                entity.Property(e => e.Siup).HasColumnName("siup");
            });

            modelBuilder.Entity<AptRefspesialistdokter>(entity =>
            {
                entity.HasKey(e => e.Kdspesialist)
                    .HasName("idx_16901_pk_apt_refspesialistdokter");

                entity.ToTable("apt_refspesialistdokter", "dbo");

                entity.Property(e => e.Kdspesialist).HasColumnName("kdspesialist");

                entity.Property(e => e.Nmspesialist).HasColumnName("nmspesialist");
            });

            modelBuilder.Entity<AptRefstatuspb>(entity =>
            {
                entity.HasKey(e => e.Statuspb)
                    .HasName("idx_16906_pk_apt_refstatuspb");

                entity.ToTable("apt_refstatuspb", "dbo");

                entity.Property(e => e.Statuspb)
                    .ValueGeneratedNever()
                    .HasColumnName("statuspb");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Nmproses).HasColumnName("nmproses");

                entity.Property(e => e.Nmstatuspb).HasColumnName("nmstatuspb");
            });

            modelBuilder.Entity<AptRefstatusverresep>(entity =>
            {
                entity.HasKey(e => e.Statusver)
                    .HasName("idx_16911_pk_apt_refstatusverresep");

                entity.ToTable("apt_refstatusverresep", "dbo");

                entity.Property(e => e.Statusver)
                    .ValueGeneratedNever()
                    .HasColumnName("statusver");

                entity.Property(e => e.Fdate)
                    .HasColumnName("fdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flagaktif)
                    .HasColumnName("flagaktif")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Fuser).HasColumnName("fuser");

                entity.Property(e => e.Keterangan).HasColumnName("keterangan");

                entity.Property(e => e.Ldate).HasColumnName("ldate");

                entity.Property(e => e.Luser).HasColumnName("luser");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
