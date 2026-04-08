using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Name", "RegistrationDate", "Surname" },
                values: new object[,]
                {
                    { 1, 25, "ivan@example.com", "Ivan", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Ivanov" },
                    { 2, 30, "petr@example.com", "Petr", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Petrov" },
                    { 3, 22, "anna@example.com", "Anna", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Smirnova" },
                    { 4, 28, "olga@example.com", "Olga", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Sidorova" },
                    { 5, 35, "dmitriy@example.com", "Dmitriy", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Kuznetsov" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
