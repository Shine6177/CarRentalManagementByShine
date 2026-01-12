using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagementByShine.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "778e4879-b5d5-4d94-b426-141580efb92b", "AQAAAAIAAYagAAAAEM/1XuqGU4Qof4EnjRAuDDcsbMRH3egfeR/4mea8WoHCJJazwtxFrJfUEqCT32c/zQ==", "5e03c4f4-2d0b-4a1d-b08b-d329e3973833" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(6994), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7013), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7185), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7188), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7347), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7349), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7351), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7354), new DateTime(2026, 1, 12, 9, 35, 34, 108, DateTimeKind.Local).AddTicks(7354) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33cc897c-5471-4bc3-929b-391f47fdc7ae", "AQAAAAIAAYagAAAAEMvDNLoskwonAQ0UwdELo3ZH7nWhN1zZbOpl/VWt1Atk9ZT1jKnfWQEpL2EcC+7bNw==", "451d9ae6-cbd4-49ad-9f9f-401bdd443265" });

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
        }
    }
}
