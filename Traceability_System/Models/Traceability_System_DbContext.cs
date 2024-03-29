﻿using System;
using System.Windows.Forms;
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
        public virtual DbSet<SerialNumber> SerialNumbers { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string readText = System.IO.File.ReadAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath)+"\\Connection.txt");
                optionsBuilder.UseSqlServer(readText);
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

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogRecord>(entity =>
            {
                entity.ToTable("LogRecord");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Piece)
                    .WithMany(p => p.LogRecords)
                    .HasForeignKey(d => d.PieceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogRecord_Pieces");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogRecords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogRecord_User");
            });

            modelBuilder.Entity<Piece>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PieceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PiecePartNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScannedDate).HasColumnType("datetime");

                entity.HasOne(d => d.UserScannedNavigation)
                    .WithMany(p => p.Pieces)
                    .HasForeignKey(d => d.UserScanned)
                    .HasConstraintName("FK_Pieces_User");
            });

            modelBuilder.Entity<SerialNumber>(entity =>
            {
                entity.HasKey(e => e.SerialNumber1);

                entity.Property(e => e.SerialNumber1)
                    .ValueGeneratedNever()
                    .HasColumnName("SerialNumber");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.HasOne(d => d.Piece)
                    .WithMany(p => p.SerialNumbers)
                    .HasForeignKey(d => d.PieceId)
                    .HasConstraintName("FK_SerialNumbers_Pieces");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SerialNumbers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SerialNumbers_User");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.Shift1);

                entity.Property(e => e.Shift1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift");

                entity.Property(e => e.HourEnd).HasColumnName("Hour_End");

                entity.Property(e => e.HourStart).HasColumnName("Hour_Start");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.ToTable("User");

                entity.Property(e => e.UserCode).ValueGeneratedNever();

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

                entity.HasOne(d => d.ShiftNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Shift)
                    .HasConstraintName("FK_User_Shifts");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
