using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cyberozunu.WebApi.Models
{
    public partial class CyberozunuContext : DbContext
    {
        public CyberozunuContext()
        {
        }

        public CyberozunuContext(DbContextOptions<CyberozunuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentDetail> StudentDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
/*            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=Cyberozunu; Trusted_Connection=true;");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RollNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
