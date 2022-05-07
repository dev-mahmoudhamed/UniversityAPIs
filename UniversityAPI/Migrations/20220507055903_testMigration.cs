using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAPI.Migrations
{
    public partial class testMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentCode",
                keyValue: "CS");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentCode",
                keyValue: "IS");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentCode",
                keyValue: "IT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentCode", "DepartmentHead", "DepartmentName" },
                values: new object[] { "CS", "Mostafa", "Computer Science" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentCode", "DepartmentHead", "DepartmentName" },
                values: new object[] { "IS", "Hesham", "Information System" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentCode", "DepartmentHead", "DepartmentName" },
                values: new object[] { "IT", "Baha", "Information Technology" });
        }
    }
}
