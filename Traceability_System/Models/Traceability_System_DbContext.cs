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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
