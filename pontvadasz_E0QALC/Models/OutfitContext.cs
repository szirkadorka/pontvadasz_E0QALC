using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pontvadasz_E0QALC.Models;

public partial class OutfitContext : DbContext
{
    public OutfitContext()
    {
    }

    public OutfitContext(DbContextOptions<OutfitContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Clothe> Clothes { get; set; }

    public virtual DbSet<Outfit> Outfits { get; set; }

    public virtual DbSet<OutfitList> OutfitLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=szoft2.database.windows.net;Initial Catalog=Outfit;User ID=szirkadorka;Password=Dorka1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Clothe>(entity =>
        {
            entity.HasKey(e => e.ClothesId);

            entity.Property(e => e.ClothesId).HasColumnName("ClothesID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.ClothesName).HasMaxLength(50);
        });

        modelBuilder.Entity<Outfit>(entity =>
        {
            entity.ToTable("Outfit");

            entity.Property(e => e.OutfitId)
                .ValueGeneratedNever()
                .HasColumnName("OutfitID");
            entity.Property(e => e.OutfitName).HasMaxLength(50);
        });

        modelBuilder.Entity<OutfitList>(entity =>
        {
            entity.HasKey(e => e.OutfitListSk);

            entity.ToTable("OutfitList");

            entity.Property(e => e.OutfitListSk)
                .ValueGeneratedNever()
                .HasColumnName("OutfitListSK");
            entity.Property(e => e.ClothesFk).HasColumnName("ClothesFK");
            entity.Property(e => e.OutfitFk).HasColumnName("OutfitFK");

            entity.HasOne(d => d.ClothesFkNavigation).WithMany(p => p.OutfitLists)
                .HasForeignKey(d => d.ClothesFk)
                .HasConstraintName("FK_OutfitList_Clothes");

            entity.HasOne(d => d.OutfitFkNavigation).WithMany(p => p.OutfitLists)
                .HasForeignKey(d => d.OutfitFk)
                .HasConstraintName("FK_OutfitList_Outfit");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
