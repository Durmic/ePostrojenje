using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ePostrojenje.WebAPI.Database
{
    public partial class _150217Context : DbContext
    {
        public _150217Context()
        {
        }

        public _150217Context(DbContextOptions<_150217Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Kupci> Kupci { get; set; }
        public virtual DbSet<MjernaMjesta> MjernaMjesta { get; set; }
        public virtual DbSet<MjernaMjestaOpreme> MjernaMjestaOpreme { get; set; }
        public virtual DbSet<Obavjestenja> Obavjestenja { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Odjeli> Odjeli { get; set; }
        public virtual DbSet<OdjeliOsoblje> OdjeliOsoblje { get; set; }
        public virtual DbSet<Opreme> Opreme { get; set; }
        public virtual DbSet<Osoblje> Osoblje { get; set; }
        public virtual DbSet<Plate> Plate { get; set; }
        public virtual DbSet<Potrosnje> Potrosnje { get; set; }
        public virtual DbSet<Racuni> Racuni { get; set; }
        public virtual DbSet<Reklamacije> Reklamacije { get; set; }
        public virtual DbSet<Rsii25092020> Rsii25092020 { get; set; }
        public virtual DbSet<Sluzbe> Sluzbe { get; set; }
        public virtual DbSet<TarifniStavovi> TarifniStavovi { get; set; }
        public virtual DbSet<Ugovori> Ugovori { get; set; }
        public virtual DbSet<VrstaAplikacije> VrstaAplikacije { get; set; }
        public virtual DbSet<VrsteKupaca> VrsteKupaca { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=150217;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kupci>(entity =>
            {
                entity.HasKey(e => e.KupacId);

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Jmbg)
                    .HasColumnName("JMBG")
                    .HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(30);

                entity.Property(e => e.MjernoMjestoId).HasColumnName("MjernoMjestoID");

                entity.Property(e => e.Odgovor)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Pitanje)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prezime).HasMaxLength(20);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.Property(e => e.VrstaKupcaId).HasColumnName("VrstaKupcaID");

                entity.HasOne(d => d.MjernoMjesto)
                    .WithMany(p => p.Kupci)
                    .HasForeignKey(d => d.MjernoMjestoId)
                    .HasConstraintName("FK_Kupci_MjernaMjesta");

                entity.HasOne(d => d.VrstaKupca)
                    .WithMany(p => p.Kupci)
                    .HasForeignKey(d => d.VrstaKupcaId)
                    .HasConstraintName("FK_Kupci_VrsteKupaca");
            });

            modelBuilder.Entity<MjernaMjesta>(entity =>
            {
                entity.HasKey(e => e.MjernoMjestoId);

                entity.Property(e => e.MjernoMjestoId).HasColumnName("MjernoMjestoID");

                entity.Property(e => e.Adresa).HasMaxLength(20);

                entity.Property(e => e.Grad).HasMaxLength(20);

                entity.Property(e => e.Pin)
                    .HasColumnName("PIN")
                    .HasMaxLength(6);

                entity.Property(e => e.PostanskiBroj)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<MjernaMjestaOpreme>(entity =>
            {
                entity.HasKey(e => e.MjernoMjestoOpremaId);

                entity.Property(e => e.MjernoMjestoOpremaId).HasColumnName("MjernoMjestoOpremaID");

                entity.Property(e => e.DatumPostavljanja).HasColumnType("date");

                entity.Property(e => e.MjernoMjestoId).HasColumnName("MjernoMjestoID");

                entity.Property(e => e.OpremaId).HasColumnName("OpremaID");

                entity.Property(e => e.VrstaUredjaja)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.MjernoMjesto)
                    .WithMany(p => p.MjernaMjestaOpreme)
                    .HasForeignKey(d => d.MjernoMjestoId)
                    .HasConstraintName("FK_MjernaMjestaOpreme_MjernaMjesta");

                entity.HasOne(d => d.Oprema)
                    .WithMany(p => p.MjernaMjestaOpreme)
                    .HasForeignKey(d => d.OpremaId)
                    .HasConstraintName("FK_MjernaMjestaOpreme_Opreme");
            });

            modelBuilder.Entity<Obavjestenja>(entity =>
            {
                entity.HasKey(e => e.ObavjestenjeId);

                entity.Property(e => e.ObavjestenjeId).HasColumnName("ObavjestenjeID");

                entity.Property(e => e.DatumPocetka).HasColumnType("datetime");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OsobljeId).HasColumnName("OsobljeID");

                entity.Property(e => e.Tekst).HasMaxLength(200);

                entity.Property(e => e.VrstaObavjestenja).HasMaxLength(20);

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Obavjestenja)
                    .HasForeignKey(d => d.OsobljeId)
                    .HasConstraintName("FK_Obavjestenja_Osoblje");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.OsobljeId).HasColumnName("OsobljeID");

                entity.Property(e => e.ReklamacijaId).HasColumnName("ReklamacijaID");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.OsobljeId)
                    .HasConstraintName("FK_Ocjene_Osoblje");

                entity.HasOne(d => d.Reklamacija)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.ReklamacijaId)
                    .HasConstraintName("FK_Ocjene_Reklamacije");
            });

            modelBuilder.Entity<Odjeli>(entity =>
            {
                entity.HasKey(e => e.OdjelId);

                entity.Property(e => e.OdjelId).HasColumnName("OdjelID");

                entity.Property(e => e.DatumOtvaranja).HasColumnType("date");

                entity.Property(e => e.DatumZatvaranja).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SluzbaId).HasColumnName("SluzbaID");

                entity.HasOne(d => d.Sluzba)
                    .WithMany(p => p.Odjeli)
                    .HasForeignKey(d => d.SluzbaId)
                    .HasConstraintName("FK_Odjeli_Sluzbe");
            });

            modelBuilder.Entity<OdjeliOsoblje>(entity =>
            {
                entity.Property(e => e.OdjeliOsobljeId).HasColumnName("OdjeliOsobljeID");

                entity.Property(e => e.OdjelId).HasColumnName("OdjelID");

                entity.Property(e => e.OsobljeId).HasColumnName("OsobljeID");

                entity.HasOne(d => d.Odjel)
                    .WithMany(p => p.OdjeliOsoblje)
                    .HasForeignKey(d => d.OdjelId)
                    .HasConstraintName("FK_OdjeliOsoblje_Odjeli");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.OdjeliOsoblje)
                    .HasForeignKey(d => d.OsobljeId)
                    .HasConstraintName("FK_OdjeliOsoblje_Osoblje");
            });

            modelBuilder.Entity<Opreme>(entity =>
            {
                entity.HasKey(e => e.OpremaId);

                entity.Property(e => e.OpremaId).HasColumnName("OpremaID");

                entity.Property(e => e.Napomena).HasMaxLength(100);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Osoblje>(entity =>
            {
                entity.Property(e => e.OsobljeId).HasColumnName("OsobljeID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Jmbg)
                    .HasColumnName("JMBG")
                    .HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(30);

                entity.Property(e => e.Odgovor)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OdjelId).HasColumnName("OdjelID");

                entity.Property(e => e.Pitanje)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prezime).HasMaxLength(20);
            });

            modelBuilder.Entity<Plate>(entity =>
            {
                entity.HasKey(e => new { e.OsobljeId, e.OdDatuma, e.DoDatuma });

                entity.Property(e => e.OsobljeId).HasColumnName("OsobljeID");

                entity.Property(e => e.OdDatuma).HasColumnType("date");

                entity.Property(e => e.DoDatuma).HasColumnType("date");

                entity.Property(e => e.Iznos).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Plate)
                    .HasForeignKey(d => d.OsobljeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plate_Osoblje");
            });

            modelBuilder.Entity<Potrosnje>(entity =>
            {
                entity.HasKey(e => e.PotrosnjaId);

                entity.Property(e => e.PotrosnjaId).HasColumnName("PotrosnjaID");

                entity.Property(e => e.DoDatuma).HasColumnType("date");

                entity.Property(e => e.OdDatuma).HasColumnType("date");

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.TarifniStavId).HasColumnName("TarifniStavID");

                entity.Property(e => e.UkupnaPotrosnja).HasColumnType("decimal(5, 1)");

                entity.HasOne(d => d.Racun)
                    .WithMany(p => p.Potrosnje)
                    .HasForeignKey(d => d.RacunId)
                    .HasConstraintName("FK_Potrosnje_Racuni");

                entity.HasOne(d => d.TarifniStav)
                    .WithMany(p => p.Potrosnje)
                    .HasForeignKey(d => d.TarifniStavId)
                    .HasConstraintName("FK_Potrosnje_TarifniStavovi");
            });

            modelBuilder.Entity<Racuni>(entity =>
            {
                entity.HasKey(e => e.RacunId);

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.DatumRacuna).HasColumnType("date");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.Napomena).HasMaxLength(100);

                entity.Property(e => e.Placen).HasDefaultValueSql("((0))");

                entity.Property(e => e.Referenca)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RokDospijeca).HasColumnType("date");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Racuni)
                    .HasForeignKey(d => d.KupacId)
                    .HasConstraintName("FK_Racuni_Kupci");
            });

            modelBuilder.Entity<Reklamacije>(entity =>
            {
                entity.HasKey(e => e.ReklamacijaId);

                entity.Property(e => e.ReklamacijaId).HasColumnName("ReklamacijaID");

                entity.Property(e => e.DatumOtvaranja).HasColumnType("date");

                entity.Property(e => e.DatumZatvaranja).HasColumnType("date");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.MjernoMjestoId).HasColumnName("MjernoMjestoID");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.OsobljeId).HasColumnName("OsobljeID");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Reklamacije)
                    .HasForeignKey(d => d.KupacId)
                    .HasConstraintName("FK_Reklamacije_Kupci");

                entity.HasOne(d => d.MjernoMjesto)
                    .WithMany(p => p.Reklamacije)
                    .HasForeignKey(d => d.MjernoMjestoId)
                    .HasConstraintName("FK_Reklamacije_MjernaMjesta");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Reklamacije)
                    .HasForeignKey(d => d.OsobljeId)
                    .HasConstraintName("FK_Reklamacije_Osoblje");
            });

            modelBuilder.Entity<Rsii25092020>(entity =>
            {
                entity.HasKey(e => e.Rsid);

                entity.ToTable("RSII25092020");

                entity.Property(e => e.Rsid).HasColumnName("RSID");

                entity.Property(e => e.DatumLogiranja).HasColumnType("date");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.PotencijalnoMaliciozan)
                    .HasColumnName("potencijalnoMaliciozan")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Rsii25092020)
                    .HasForeignKey(d => d.KupacId)
                    .HasConstraintName("FK_RSII25092020_Kupci");
            });

            modelBuilder.Entity<Sluzbe>(entity =>
            {
                entity.HasKey(e => e.SluzbaId);

                entity.Property(e => e.SluzbaId).HasColumnName("SluzbaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TarifniStavovi>(entity =>
            {
                entity.HasKey(e => e.TarifniStavId);

                entity.Property(e => e.TarifniStavId).HasColumnName("TarifniStavID");

                entity.Property(e => e.ManjaTarifa).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SrednjaTarifa).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.VecaTarifa).HasColumnType("decimal(2, 2)");
            });

            modelBuilder.Entity<Ugovori>(entity =>
            {
                entity.HasKey(e => e.UgovorId);

                entity.Property(e => e.UgovorId).HasColumnName("UgovorID");

                entity.Property(e => e.BrojUgovora)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumSklapanja).HasColumnType("date");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.Opis).HasMaxLength(300);

                entity.Property(e => e.OsobljeId).HasColumnName("OsobljeID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TarifniStavId).HasColumnName("TarifniStavID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Ugovori)
                    .HasForeignKey(d => d.KupacId)
                    .HasConstraintName("FK_Ugovori_Kupci");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Ugovori)
                    .HasForeignKey(d => d.OsobljeId)
                    .HasConstraintName("FK_Ugovori_Osoblje");

                entity.HasOne(d => d.TarifniStav)
                    .WithMany(p => p.Ugovori)
                    .HasForeignKey(d => d.TarifniStavId)
                    .HasConstraintName("FK_Ugovori_TarifniStavovi");
            });

            modelBuilder.Entity<VrstaAplikacije>(entity =>
            {
                entity.HasKey(e => e.VrstaId);

                entity.Property(e => e.VrstaId)
                    .HasColumnName("VrstaID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<VrsteKupaca>(entity =>
            {
                entity.HasKey(e => e.VrstaKupcaId);

                entity.Property(e => e.VrstaKupcaId).HasColumnName("VrstaKupcaID");

                entity.Property(e => e.Napomena).HasMaxLength(100);

                entity.Property(e => e.Popust).HasColumnType("decimal(5, 2)");
            });
        }
    }
}
