using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagementByShine.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7485), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7500), "Black", "System" },
                    { 2, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7502), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7502), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7671), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7671), "BMW", "System" },
                    { 2, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7673), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7673), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7731), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7732), "i4", "System" },
                    { 2, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7733), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7734), "X5", "System" },
                    { 3, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7735), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7735), "Prius", "System" },
                    { 4, "System", new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7736), new DateTime(2026, 1, 11, 14, 0, 40, 782, DateTimeKind.Local).AddTicks(7737), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
