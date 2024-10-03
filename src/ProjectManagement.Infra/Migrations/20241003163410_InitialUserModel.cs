using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserModel",
                keyColumn: "Id",
                keyValue: new Guid("49bf81a0-2b4d-4ed9-8905-132a721566c2"));

            migrationBuilder.DeleteData(
                table: "UserModel",
                keyColumn: "Id",
                keyValue: new Guid("b6827f9c-9110-410a-9a23-0816e3e26a6b"));

            migrationBuilder.DeleteData(
                table: "UserModel",
                keyColumn: "Id",
                keyValue: new Guid("dea02098-0b7a-4799-be9f-e345857fe825"));

            migrationBuilder.InsertData(
                table: "UserModel",
                columns: new[] { "Id", "AccessType", "Created_At", "Name", "Updated_At" },
                values: new object[,]
                {
                    { new Guid("b24c8031-7e17-4c4a-bc26-cf07b7ec1db4"), 2, new DateTime(2024, 10, 3, 16, 34, 9, 834, DateTimeKind.Utc).AddTicks(7021), "Thais Vilas Boas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6cb6bab-752f-43b1-aa9a-404a042484f0"), 1, new DateTime(2024, 10, 3, 16, 34, 9, 834, DateTimeKind.Utc).AddTicks(7018), "Leandro Vilas Boas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f34d886a-b360-46d5-99b4-f0d9a6dbe282"), 2, new DateTime(2024, 10, 3, 16, 34, 9, 834, DateTimeKind.Utc).AddTicks(7023), "Mariana Vilas Boas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserModel",
                keyColumn: "Id",
                keyValue: new Guid("b24c8031-7e17-4c4a-bc26-cf07b7ec1db4"));

            migrationBuilder.DeleteData(
                table: "UserModel",
                keyColumn: "Id",
                keyValue: new Guid("e6cb6bab-752f-43b1-aa9a-404a042484f0"));

            migrationBuilder.DeleteData(
                table: "UserModel",
                keyColumn: "Id",
                keyValue: new Guid("f34d886a-b360-46d5-99b4-f0d9a6dbe282"));

            migrationBuilder.InsertData(
                table: "UserModel",
                columns: new[] { "Id", "AccessType", "Created_At", "Name", "Updated_At" },
                values: new object[,]
                {
                    { new Guid("49bf81a0-2b4d-4ed9-8905-132a721566c2"), 2, new DateTime(2024, 10, 3, 13, 30, 49, 248, DateTimeKind.Local).AddTicks(4416), "Thais Vilas Boas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6827f9c-9110-410a-9a23-0816e3e26a6b"), 1, new DateTime(2024, 10, 3, 13, 30, 49, 248, DateTimeKind.Local).AddTicks(4399), "Leandro Vilas Boas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dea02098-0b7a-4799-be9f-e345857fe825"), 2, new DateTime(2024, 10, 3, 13, 30, 49, 248, DateTimeKind.Local).AddTicks(4418), "Mariana Vilas Boas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
