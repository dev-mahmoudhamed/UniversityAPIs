using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAPI.Migrations
{
    public partial class seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: new Guid("0f3fa505-d206-47ab-af30-d607f0d5b637"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentCode", "DepartmentHead", "DepartmentName" },
                values: new object[] { "CS", "Mostafa", "Computer Science" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentCode",
                keyValue: "CS");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DepartmentCode", "GPA", "StudentName" },
                values: new object[] { new Guid("0f3fa505-d206-47ab-af30-d607f0d5b637"), "CS", 3.7f, "Mahmoud" });
        }
    }
}
