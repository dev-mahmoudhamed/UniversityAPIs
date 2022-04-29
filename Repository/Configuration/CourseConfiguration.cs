using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData 
                (
                new Course
                {
                    CourseCode = "CS101",
                    CourseName = "Intro to CS",
                    CourseInstractor = "Nariman",
                    DepartmentCode = "CS"
                },
                new Course
                {
                    CourseCode = "CS101",
                    CourseName = "Intro to CS",
                    CourseInstractor = "Nariman",
                    DepartmentCode = "CS"
                },
                new Course
                {
                    CourseCode = "IT101",
                    CourseName = "Intro to IT",
                    CourseInstractor = "Hadeer",
                    DepartmentCode = "IT"
                }
                );
        }
    }
}
