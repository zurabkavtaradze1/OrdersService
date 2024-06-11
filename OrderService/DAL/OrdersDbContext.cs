using Microsoft.EntityFrameworkCore;
using OrderService.DAL.Entities;

namespace OrderService.DAL
{
    public class OrdersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.FirstName).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(x => x.LastName).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(x => x.Email).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(x => x.UserName).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(500);

            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Item>().HasKey(x => x.Id);
            modelBuilder.Entity<Item>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Item>().Property(x => x.Description).HasMaxLength(500);
            
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "Laptop", Description = "A high-performance laptop for work and gaming.", Price = 1499.99m },
                new Item { Id = 2, Name = "Smartphone", Description = "A flagship smartphone with a powerful camera.", Price = 999.99m },
                new Item { Id = 3, Name = "Headphones", Description = "Wireless headphones with active noise cancellation.", Price = 199.99m },
                new Item { Id = 4, Name = "Tablet", Description = "A lightweight tablet for entertainment and productivity.", Price = 499.99m },
                new Item { Id = 5, Name = "Smartwatch", Description = "A smartwatch with health and fitness tracking features.", Price = 299.99m },
                new Item { Id = 6, Name = "Camera", Description = "A DSLR camera with professional-grade features.", Price = 1299.99m },
                new Item { Id = 7, Name = "TV", Description = "A 4K smart TV with HDR support for an immersive viewing experience.", Price = 799.99m },
                new Item { Id = 8, Name = "Gaming Console", Description = "A gaming console with 4K gaming capabilities.", Price = 399.99m },
                new Item { Id = 9, Name = "Monitor", Description = "A high-resolution monitor for productivity and gaming.", Price = 299.99m },
                new Item { Id = 10, Name = "Speaker System", Description = "A surround sound speaker system for home entertainment.", Price = 499.99m }
            );

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
