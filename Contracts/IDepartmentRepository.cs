using Entities.Models;

namespace Contracts
{
    public interface IDepartmentRepository
    {
       Task<IEnumerable<Department>> GetDepartmentsAsync(bool trackChanges);

        Task<Department> GetDepartmentAsync(string departmentCode, bool trackChanges);
        void CreateDepartment(Department department);

        void DeleteDepartment(Department department);
    }
}
