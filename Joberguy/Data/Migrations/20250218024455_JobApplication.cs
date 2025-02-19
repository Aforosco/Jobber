using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joberguy.Data.Migrations
{
    /// <inheritdoc />
    public partial class JobApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApplicationDate",
                table: "applications",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "applications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HasApplied",
                table: "applications",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "applications",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "applications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobLocation",
                table: "applications",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_applications_JobId",
                table: "applications",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_applications_jobs_JobId",
                table: "applications",
                column: "JobId",
                principalTable: "jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_applications_jobs_JobId",
                table: "applications");

            migrationBuilder.DropIndex(
                name: "IX_applications_JobId",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "ApplicationDate",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "HasApplied",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "applications");

            migrationBuilder.DropColumn(
                name: "JobLocation",
                table: "applications");
        }
    }
}
