using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData
                (
                new Department
                {
                    DepartmentCode = "CS",
                    DepartmentName = "Computer Science",
                    DepartmentHead = "Mostafa",
                },
                new Department
                {
                    DepartmentCode = "IT",
                    DepartmentName = "Information Technology",
                    DepartmentHead = "Baha",
                },
                new Department
                {
                    DepartmentCode = "IS",
                    DepartmentName = "Information System",
                    DepartmentHead = "Hesham",
                }
                );
        }
    }
}
