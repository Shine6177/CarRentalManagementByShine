using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagementByShine.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "33cc897c-5471-4bc3-929b-391f47fdc7ae", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMvDNLoskwonAQ0UwdELo3ZH7nWhN1zZbOpl/VWt1Atk9ZT1jKnfWQEpL2EcC+7bNw==", null, false, "451d9ae6-cbd4-49ad-9f9f-401bdd443265", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8353), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8368), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8512), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8513), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8609), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8611), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8612), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8614), new DateTime(2026, 1, 11, 14, 46, 50, 556, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8463), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8481), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8645), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8647), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8709), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8711), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8712), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8714), new DateTime(2026, 1, 11, 14, 32, 5, 749, DateTimeKind.Local).AddTicks(8714) });
        }
    }
}
