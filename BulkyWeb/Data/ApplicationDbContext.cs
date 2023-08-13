using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, DispayOrder = 1, Name = "Action" },
                new Category { id = 2, DispayOrder = 2, Name = "Sci-Fi" },
                new Category { id = 3, DispayOrder = 3, Name = "Rom-Com" },
                new Category { id = 4, DispayOrder = 4, Name = "Horror" }
                );
        }
    }
}
