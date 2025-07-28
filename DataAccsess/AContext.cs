using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entity;

public partial class AContext : DbContext
{
    public AContext()
    {
    }

    public AContext(DbContextOptions<AContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doktorlar> Doktorlars { get; set; }

    public virtual DbSet<Durum> Durums { get; set; }

    public virtual DbSet<Hastalar> Hastalars { get; set; }

    public virtual DbSet<Randevular> Randevulars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ENESPC\\HIZIR;Database=a;TrustServerCertificate=True;;User Id=sa;Password=T902HDA_42;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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
            entity.Property(e => e.Cinsiyet).HasMaxLength(10);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Soyad).HasMaxLength(50);
            entity.Property(e => e.TckimlikNo)
                .HasMaxLength(11)
                .HasColumnName("TCKimlikNo");
            entity.Property(e => e.TelefonNumarasi).HasMaxLength(15);
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
