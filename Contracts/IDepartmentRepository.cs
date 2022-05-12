
using Entities.Models;

namespace Contracts
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments(bool trackChanges);

        Department GetDepartment(string DepartmentCode, bool trackChanges);
    }
}
