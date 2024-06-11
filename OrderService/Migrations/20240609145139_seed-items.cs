using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderService.Migrations
{
    /// <inheritdoc />
    public partial class seeditems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A high-performance laptop for work and gaming.", "Laptop", 1499.99m },
                    { 2, "A flagship smartphone with a powerful camera.", "Smartphone", 999.99m },
                    { 3, "Wireless headphones with active noise cancellation.", "Headphones", 199.99m },
                    { 4, "A lightweight tablet for entertainment and productivity.", "Tablet", 499.99m },
                    { 5, "A smartwatch with health and fitness tracking features.", "Smartwatch", 299.99m },
                    { 6, "A DSLR camera with professional-grade features.", "Camera", 1299.99m },
                    { 7, "A 4K smart TV with HDR support for an immersive viewing experience.", "TV", 799.99m },
                    { 8, "A gaming console with 4K gaming capabilities.", "Gaming Console", 399.99m },
                    { 9, "A high-resolution monitor for productivity and gaming.", "Monitor", 299.99m },
                    { 10, "A surround sound speaker system for home entertainment.", "Speaker System", 499.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
