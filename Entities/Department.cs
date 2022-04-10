using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Entities
{
    [Keyless]
    public class Department
    {
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }
    }
}