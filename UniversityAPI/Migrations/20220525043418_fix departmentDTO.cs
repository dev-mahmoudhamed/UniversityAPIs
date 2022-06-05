using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAPI.Migrations
{
    public partial class fixdepartmentDTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentCode",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentCode",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentCode",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DepartmentCode",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentCode",
                table: "Students",
                column: "DepartmentCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentCode",
                table: "Students",
                column: "DepartmentCode",
                principalTable: "Departments",
                principalColumn: "DepartmentCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
