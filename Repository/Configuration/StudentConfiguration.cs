using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
                (
                new Student
                {
                    StudentID = Guid.NewGuid(),
                    StudentName = "Mahmoud",
                    GPA = 3.7f,
                    DepartmentCode = "CS",
                    
                }
                );
        }
    }
}
