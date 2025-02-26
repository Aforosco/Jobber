using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joberguy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1140), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1130), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1130), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1130), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1120), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1120), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1120), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1110), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1110), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 28, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1100), new DateTime(2025, 2, 26, 0, 0, 36, 895, DateTimeKind.Local).AddTicks(1100) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8190), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8180), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8180), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8180), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8170), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8170), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8170), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8160), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8160), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 3, 22, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8150), new DateTime(2025, 2, 20, 14, 49, 42, 228, DateTimeKind.Local).AddTicks(8150) });
        }
    }
}
