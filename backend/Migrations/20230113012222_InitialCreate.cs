using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherForecasts",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecasts", x => x.Date);
                });

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { new DateTime(2023, 1, 12, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5478), "Freezing", 0 },
                    { new DateTime(2023, 1, 13, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5510), "Bracing", 1 },
                    { new DateTime(2023, 1, 14, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5513), "Chilly", 2 },
                    { new DateTime(2023, 1, 15, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5515), "Cool", 3 },
                    { new DateTime(2023, 1, 16, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5517), "Mild", 4 },
                    { new DateTime(2023, 1, 17, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5520), "Warm", 5 },
                    { new DateTime(2023, 1, 18, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5522), "Balmy", 6 },
                    { new DateTime(2023, 1, 19, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5524), "Hot", 7 },
                    { new DateTime(2023, 1, 20, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5527), "Sweltering", 8 },
                    { new DateTime(2023, 1, 21, 19, 22, 22, 548, DateTimeKind.Local).AddTicks(5529), "Scorching", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecasts");
        }
    }
}
