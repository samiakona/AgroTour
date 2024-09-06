using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgroTour_Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Capacity", "Cost", "LocationAddress", "LocationCity", "locationName" },
                values: new object[,]
                {
                    { 1, 500, 100, "ShaBhag", "Dhaka", "National Museum" },
                    { 2, 1000, 50, "Mirpur-1", "Dhaka", "ZOO" },
                    { 3, 500, 100, "Bijoy Soroni", "Dhaka", "National Military Museum" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
