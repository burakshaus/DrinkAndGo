using Microsoft.EntityFrameworkCore;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data
{
    public class DrinkAndGoDbContext : DbContext
    {
        public DrinkAndGoDbContext(DbContextOptions<DrinkAndGoDbContext> options) : base(options)
        {
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Drink entity
            modelBuilder.Entity<Drink>()
                .HasKey(d => d.DrinkId); // Define primary key for Drink

            modelBuilder.Entity<Drink>()
                .Property(d => d.Name)
                .IsRequired(); // Name is required

            modelBuilder.Entity<Drink>()
                .Property(d => d.Price)
                .HasColumnType("decimal(18,2)"); // Specify SQL column type for Price

            // Configure Category entity
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId); // Define primary key for Category

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Drinks) // One Category has many Drinks
                .WithOne(d => d.Category) // Each Drink belongs to one Category
                .HasForeignKey(d => d.CategoryId); // Define foreign key in Drink entity

            // Seed initial data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Category 1", Description = "Description of Category 1" },
                new Category { CategoryId = 2, CategoryName = "Category 2", Description = "Description of Category 2" }
            );

            modelBuilder.Entity<Drink>().HasData(
                new Drink { DrinkId = 1, Name = "Drink 1", ShortDescription = "Short description of Drink 1", LongDescription = "Long description of Drink 1", Price = 9.99m, ImgUrl = "url_to_image_1", ImageThumbnailUrl = "thumbnail_url_1", IsPreferredDrink = true, InStock = true, CategoryId = 1 },
                new Drink { DrinkId = 2, Name = "Drink 2", ShortDescription = "Short description of Drink 2", LongDescription = "Long description of Drink 2", Price = 7.99m, ImgUrl = "url_to_image_2", ImageThumbnailUrl = "thumbnail_url_2", IsPreferredDrink = false, InStock = true, CategoryId = 2 }
            );
        }
    }
}
