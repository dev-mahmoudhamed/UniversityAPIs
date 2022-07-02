using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAPI.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca83b05-06a9-46c4-9e44-761e308b0a0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b733e093-866f-4c63-a3f0-819c51bcf99a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63f365d4-c04e-4ae9-ac68-afce137c1257", "36060d9c-aa8b-45cd-b575-c3249052df2d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b85396d-bc0c-45ef-9a64-54a5ba391eae", "fb4d5db0-1021-4274-8cf8-c9e91bcec430", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63f365d4-c04e-4ae9-ac68-afce137c1257");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b85396d-bc0c-45ef-9a64-54a5ba391eae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aca83b05-06a9-46c4-9e44-761e308b0a0d", "9db8176f-4c3d-40a9-aa1f-4bd9a5207306", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b733e093-866f-4c63-a3f0-819c51bcf99a", "ac0a5611-617f-417f-9580-7d0de1723a45", "Administrator", "ADMINISTRATOR" });
        }
    }
}
