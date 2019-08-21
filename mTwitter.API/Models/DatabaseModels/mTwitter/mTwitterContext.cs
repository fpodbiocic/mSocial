using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mTwitter.API.Models.DatabaseModels.mTwitter
{
    public partial class mTwitterContext : DbContext
    {
        public mTwitterContext()
        {
        }

        public mTwitterContext(DbContextOptions<mTwitterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var appSettingsJson = AppsettingsJson.GetAppSettings();
                var connectionString = appSettingsJson["ConnectionStrings:mTwitterDatabase"];

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:DefaultSchema", "db_owner");

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });
        }
    }
}
