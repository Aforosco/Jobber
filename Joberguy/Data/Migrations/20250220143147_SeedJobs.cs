using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Joberguy.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "Id", "JobDescription", "JobLocation", "JobRequirement", "JobTitle", "expiringDate", "postDateTime" },
                values: new object[,]
                {
                    { 1, "Develop and maintain software applications.", "New York, USA", "C#, .NET, SQL", "Software Engineer", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5580) },
                    { 2, "Analyze data and generate reports.", "San Francisco, USA", "Python, SQL, Power BI", "Data Analyst", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5580) },
                    { 3, "Protect company assets from cyber threats.", "London, UK", "Network Security, Ethical Hacking", "Cybersecurity Specialist", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5590) },
                    { 4, "Design user-friendly interfaces.", "Remote", "Figma, Adobe XD, HTML/CSS", "UX/UI Designer", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5590) },
                    { 5, "Manage project timelines and resources.", "Berlin, Germany", "Agile, Scrum, PMP", "Project Manager", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5590) },
                    { 6, "Develop AI models and algorithms.", "Toronto, Canada", "TensorFlow, Machine Learning, Python", "AI Engineer", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5600) },
                    { 7, "Maintain CI/CD pipelines.", "Sydney, Australia", "AWS, Kubernetes, Docker", "DevOps Engineer", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5600) },
                    { 8, "Develop and execute marketing strategies.", "Paris, France", "SEO, Google Ads, Content Marketing", "Marketing Manager", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5600) },
                    { 9, "Manage hiring and employee relations.", "Dubai, UAE", "HR Management, Recruitment", "HR Specialist", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5610) },
                    { 10, "Develop decentralized applications.", "Singapore", "Solidity, Ethereum, Smart Contracts", "Blockchain Developer", new DateTime(2025, 3, 22, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 2, 20, 14, 31, 47, 684, DateTimeKind.Local).AddTicks(5610) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
