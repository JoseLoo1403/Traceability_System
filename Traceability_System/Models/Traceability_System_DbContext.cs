using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Traceability_System.Models
{
    public partial class Traceability_System_DbContext : DbContext
    {
        public Traceability_System_DbContext()
        {
        }

        public Traceability_System_DbContext(DbContextOptions<Traceability_System_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<LogRecord> LogRecords { get; set; }
        public virtual DbSet<Piece> Pieces { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-8C1AB2N;Database=Traceability_System_Db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogRecord>(entity =>
            {
                entity.ToTable("LogRecord");

                entity.Property(e => e.Accion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogRecords)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LogRecord_User");
            });

            modelBuilder.Entity<Piece>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PieceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScannedDate).HasColumnType("datetime");

                entity.HasOne(d => d.UserScannedNavigation)
                    .WithMany(p => p.Pieces)
                    .HasForeignKey(d => d.UserScanned)
                    .HasConstraintName("FK_Pieces_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
