using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joberguy.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "applications",
                newName: "FilePath");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "applications",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StreetAddress = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4440), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4440), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4440), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "expiringDate", "postDateTime" },
                values: new object[] { new DateTime(2025, 4, 1, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4420), new DateTime(2025, 3, 2, 5, 50, 22, 615, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.CreateIndex(
                name: "IX_applications_AddressId",
                table: "applications",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_applications_Address_AddressId",
                table: "applications",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_applications_Address_AddressId",
                table: "applications");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_applications_AddressId",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "applications");

            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "applications",
                newName: "Address");

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
    }
}
