using EntityFramework.Performance.Entities;
using EntityFramework.Performance.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Performance
{
    public class CoreDbContext : DbContext 
    {
        public DbSet<User> User { get; set; }
        public DbSet<TermAndCondition> TermAndCondition { get; set; }
        public DbSet<EngagementUser> EngagementUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=.;Database=EFPerformance;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}