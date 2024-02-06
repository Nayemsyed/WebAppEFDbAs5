using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppEFDbAs5.Models
{
    public partial class EFDbFirstContext : DbContext
    {
        public EFDbFirstContext()
        {
        }

        public EFDbFirstContext(DbContextOptions<EFDbFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-6COE67H;database=EFDbFirst;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.PlayerId).ValueGeneratedNever();

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasColumnName("LName");

                entity.Property(e => e.Team).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
