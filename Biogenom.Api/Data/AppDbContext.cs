using Biogenom.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biogenom.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<NutritionReport> NutritionReports { get; set; }
        public DbSet<NutrientIntake> NutrientIntakes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NutritionReport>()
                .HasMany(r => r.Intakes)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<NutritionReport>()
                .HasMany(r => r.Supplements)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
