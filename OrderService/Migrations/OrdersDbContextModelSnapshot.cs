﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderService.DAL;

#nullable disable

namespace OrderService.Migrations
{
    [DbContext(typeof(OrdersDbContext))]
    partial class OrdersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderService.DAL.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Items", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A high-performance laptop for work and gaming.",
                            Name = "Laptop",
                            Price = 1499.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "A flagship smartphone with a powerful camera.",
                            Name = "Smartphone",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Wireless headphones with active noise cancellation.",
                            Name = "Headphones",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "A lightweight tablet for entertainment and productivity.",
                            Name = "Tablet",
                            Price = 499.99m
                        },
                        new
                        {
                            Id = 5,
                            Description = "A smartwatch with health and fitness tracking features.",
                            Name = "Smartwatch",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 6,
                            Description = "A DSLR camera with professional-grade features.",
                            Name = "Camera",
                            Price = 1299.99m
                        },
                        new
                        {
                            Id = 7,
                            Description = "A 4K smart TV with HDR support for an immersive viewing experience.",
                            Name = "TV",
                            Price = 799.99m
                        },
                        new
                        {
                            Id = 8,
                            Description = "A gaming console with 4K gaming capabilities.",
                            Name = "Gaming Console",
                            Price = 399.99m
                        },
                        new
                        {
                            Id = 9,
                            Description = "A high-resolution monitor for productivity and gaming.",
                            Name = "Monitor",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 10,
                            Description = "A surround sound speaker system for home entertainment.",
                            Name = "Speaker System",
                            Price = 499.99m
                        });
                });

            modelBuilder.Entity("OrderService.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
