using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAPI.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseInstractor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Course_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentID",
                table: "Course",
                column: "StudentID");
        }
    }
}
