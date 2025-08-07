using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess;

public partial class AContext : DbContext
{
    public AContext()
    {
    }

    public AContext(DbContextOptions<AContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cin> Cins { get; set; }

    public virtual DbSet<Doktorlar> Doktorlars { get; set; }

    public virtual DbSet<Durum> Durums { get; set; }

    public virtual DbSet<Hastalar> Hastalars { get; set; }

    public virtual DbSet<Randevular> Randevulars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cin>(entity =>
        {
            entity.ToTable("cins");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Cinsiyet)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("cinsiyet");
        });

        modelBuilder.Entity<Doktorlar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doktorla__77AFB941A65710E5");

            entity.ToTable("Doktorlar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AktifMi).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Soyad).HasMaxLength(50);
            entity.Property(e => e.TelefonNumarasi).HasMaxLength(15);
            entity.Property(e => e.UzmanlikAlani).HasMaxLength(100);
        });

        modelBuilder.Entity<Durum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_durum");

            entity.ToTable("Durum");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Durum1)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("Durum");
        });

        modelBuilder.Entity<Hastalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hastalar__114C5CABA8402F55");

            entity.ToTable("Hastalar");

            entity.HasIndex(e => e.TckimlikNo, "UQ__Hastalar__7E1935ED71914883")
                .IsUnique()
                .HasFilter("([TCKimlikNo] IS NOT NULL)");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adres).HasMaxLength(250);
            entity.Property(e => e.Cinsid).HasColumnName("cinsid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Soyad).HasMaxLength(50);
            entity.Property(e => e.TckimlikNo)
                .HasMaxLength(11)
                .HasColumnName("TCKimlikNo");
            entity.Property(e => e.TelefonNumarasi).HasMaxLength(15);

            entity.HasOne(d => d.Cins).WithMany(p => p.Hastalars)
                .HasForeignKey(d => d.Cinsid)
                .HasConstraintName("FK_Hastalar_cins");

            entity.HasOne(d => d.Doktor).WithMany(p => p.Hastalars)
                .HasForeignKey(d => d.Doktorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hastalar_Doktorlar");
        });

        modelBuilder.Entity<Randevular>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Randevul__3214EC07748D76A8");

            entity.ToTable("Randevular");

            entity.HasOne(d => d.Doktor).WithMany(p => p.Randevulars)
                .HasForeignKey(d => d.DoktorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Randevular_Doktorlar");

            entity.HasOne(d => d.Hasta).WithMany(p => p.Randevulars)
                .HasForeignKey(d => d.HastaId)
                .HasConstraintName("FK_Randevular_Hastalar");

            entity.HasOne(d => d.RandevuDurumuNavigation).WithMany(p => p.Randevulars)
                .HasForeignKey(d => d.RandevuDurumu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Randevular_Durum");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
