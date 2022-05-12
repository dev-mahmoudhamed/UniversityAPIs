
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentDTO> GetDepartments(bool trackChanges);
        DepartmentDTO GetDepartment(string departmentCode, bool trackChanges);

    }
}
