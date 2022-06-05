
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDTO>> GetDepartmentsAsync(bool trackChanges);
        Task<DepartmentDTO> GetDepartmentAsync(string departmentCode, bool trackChanges);
        Task<DepartmentDTO> CreateDepartmentAsync(DepartmentDTO department);
        Task DeleteDepartmentAsync(string departmentId, bool trackChanges);
        Task UpdateDepartmentAsync(string departmentId, DepartmentDTO newDepartment, bool trackChanges);

    }
}
