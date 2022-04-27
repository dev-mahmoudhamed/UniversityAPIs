using Microsoft.EntityFrameworkCore;
using UniversityAPI.Entities;

namespace UniversityAPI.Data
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
        {
        }

        // Include properties of type DbSet<T> representing TABLE in the database.
        public DbSet<Student> Students { get; set; }
    }
}
