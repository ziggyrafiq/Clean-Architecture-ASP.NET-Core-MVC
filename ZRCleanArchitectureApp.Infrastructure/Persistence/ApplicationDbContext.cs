using Microsoft.EntityFrameworkCore;
using ZRCleanArchitectureApp.Domain.Entities;

namespace ZRCleanArchitectureApp.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for your domain entities
        public DbSet<Product> Products { get; set; }
        // Other DbSet properties...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships, constraints, and seed data here
        }
    }
}
