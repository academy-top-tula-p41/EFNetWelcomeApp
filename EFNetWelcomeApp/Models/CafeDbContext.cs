using EFNetWelcomeApp.Models.ModelsConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp.Models
{
    public class CafeDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Topping> Toppings { get; set; } = null!;
        public DbSet<Dish> Dishes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .Build();
            string? connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // FluentAPI

            //modelBuilder.Ignore<Topping>();

            modelBuilder.ApplyConfiguration(new ToppingConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DishConfiguration());

            //modelBuilder.Entity<Dish>()
            //            .HasOne(d => d.Category)
            //            .WithMany(c => c.Dishes)
            //            .HasForeignKey(d => d.CategoryId);
        }
    }
}
