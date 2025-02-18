using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joberguy.Data.Migrations
{
    /// <inheritdoc />
    public partial class HasApplied : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "expiringDate",
                table: "jobs",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "postDateTime",
                table: "jobs",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "applications",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_applications_UserId",
                table: "applications",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_applications_AspNetUsers_UserId",
                table: "applications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_applications_AspNetUsers_UserId",
                table: "applications");

            migrationBuilder.DropIndex(
                name: "IX_applications_UserId",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "expiringDate",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "postDateTime",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "applications");
        }
    }
}
