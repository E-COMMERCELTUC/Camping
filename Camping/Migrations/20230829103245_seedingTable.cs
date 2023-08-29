using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Camping.Migrations
{
    /// <inheritdoc />
    public partial class seedingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "contains all the tables and chairs you need for camping ", "tables & Chairs" },
                    { 2, "contains all the types of tents ", "tents" },
                    { 3, "contains all the types of  Accessories", "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryID", "Manufacturer", "Name", "Spec" },
                values: new object[,]
                {
                    { 1, 1, "Ikea", "wooden table", "size: 2*3*1.5 m, color:black , matireal= wood" },
                    { 2, 1, "Ikea", "steel table", "size: 2*3*1.5 m, color:silver , matireal= steel" },
                    { 3, 2, "renvate", "Armor tent ", "size: 1.5*2*3 m, color:black , matireal= wool" },
                    { 4, 2, "renvate", "small tent ", "size: 2*2*2 m, color:red , matireal= wool" },
                    { 5, 3, "nike", "water bottle", "size: medeum, color:black , matireal= plastic" },
                    { 6, 3, "nike", "climing wear ", "size: xl, color:red , matireal= cotten" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
