using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Infra.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessType", "Name" },
                values: new object[,]
                {
                    { new Guid("7007a3ac-d496-4f8b-84fd-22cd72910938"), 1, "Leandro Vilas Boas" },
                    { new Guid("9991d6cb-dd0e-4ffe-ab1f-c67b6babe9cf"), 1, "Thais Vilas Boas" },
                    { new Guid("ae4b6e28-67ad-4b07-a9cd-6f7e5a0af6cc"), 1, "Mariana Vilas Boas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7007a3ac-d496-4f8b-84fd-22cd72910938"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9991d6cb-dd0e-4ffe-ab1f-c67b6babe9cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae4b6e28-67ad-4b07-a9cd-6f7e5a0af6cc"));
        }
    }
}
