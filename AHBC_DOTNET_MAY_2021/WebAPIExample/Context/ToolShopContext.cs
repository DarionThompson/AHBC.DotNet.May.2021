using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIExample.Models;

namespace WebAPIExample.Context
{
    public class ToolShopContext : DbContext 
    {
        public DbSet<Tool> Tools { get; set; }

        public DbSet<Part> Parts { get; set; }

        public ToolShopContext(DbContextOptions<ToolShopContext> options) : base(options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\LocalDb;Database=ToolShop;Trusted_Connection=true;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API 
            modelBuilder.Entity<Tool>(
                entity => entity.HasKey(t => t.Id));

            modelBuilder.Entity<Tool>().HasData(
                new Tool { Id = 4, Name = "Hammer", Price = 9.99, Quanity = 30 });

            modelBuilder.Entity<Part>(
                entity => entity.HasKey(t => t.Id));

            modelBuilder.Entity<Part>().HasData(new Part { Id = 1, Name = "Handle", Price = 2.99, Quanity = 15 });
    }
    }
}
