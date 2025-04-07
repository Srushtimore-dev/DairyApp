using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DairyApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "went hikking with srushti...!!", new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "went Hikking " },
                    { 2, "went shopping with srushti...!!", new DateTime(2024, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "went shopping" },
                    { 3, "went bookreading with srushti..!!", new DateTime(2024, 2, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "went bookreading" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
