using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AlertsProject.Models
{
    public partial class AliesAlertsDBContext : DbContext
    {
        public AliesAlertsDBContext()
        {
        }

        public AliesAlertsDBContext(DbContextOptions<AliesAlertsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlertsTable> AlertsTables { get; set; } = null!;
        public virtual DbSet<ErrorAlert> ErrorAlerts { get; set; } = null!;
        public DbSet<Usersinfo> Usersinfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5CBKT9S//MSSQLSERVER1;Database=AliesAlertsDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlertsTable>(entity =>
            {
                entity.ToTable("AlertsTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.اسمالخطأ)
                    .HasMaxLength(255)
                    .HasColumnName("اسم الخطأ");

                entity.Property(e => e.رمزالخطأ).HasColumnName("رمز الخطأ");

                entity.Property(e => e.شرحمختصر).HasColumnName("شرح مختصر");

                entity.Property(e => e.نوعالخطأ)
                    .HasMaxLength(255)
                    .HasColumnName("نوع الخطأ");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
