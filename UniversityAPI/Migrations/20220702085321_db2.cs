using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAPI.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4e5dbf83-67eb-40f2-986b-0e03e2da1cff", "5e26a99e-f3ef-4b69-879f-3d0b0cf15a45", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "759b1448-8154-4703-9a75-ee025ac10b20", "a2ed1660-a41e-4b1c-9aa7-09b0359b0a2f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e5dbf83-67eb-40f2-986b-0e03e2da1cff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "759b1448-8154-4703-9a75-ee025ac10b20");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63f365d4-c04e-4ae9-ac68-afce137c1257", "36060d9c-aa8b-45cd-b575-c3249052df2d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b85396d-bc0c-45ef-9a64-54a5ba391eae", "fb4d5db0-1021-4274-8cf8-c9e91bcec430", "Manager", "MANAGER" });
        }
    }
}
