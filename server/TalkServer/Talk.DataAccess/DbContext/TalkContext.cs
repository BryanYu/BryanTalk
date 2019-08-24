using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Talk.DataAccess.Models
{
    public partial class TalkContext : DbContext
    {
        public TalkContext()
        {
        }

        public TalkContext(DbContextOptions<TalkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=Talk;User=sa;Password=!@D58526;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
