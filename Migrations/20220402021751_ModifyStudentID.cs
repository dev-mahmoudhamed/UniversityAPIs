using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wepAPI.Migrations
{
    public partial class ModifyStudentID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Students_StudentId",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Course",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Course_StudentId",
                table: "Course",
                newName: "IX_Course_StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Students_StudentID",
                table: "Course",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Students_StudentID",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Course",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_StudentID",
                table: "Course",
                newName: "IX_Course_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Students_StudentId",
                table: "Course",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");
        }
    }
}
