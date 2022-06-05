using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Department>> GetDepartmentsAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Department> GetDepartmentAsync(string departmentCode, bool trackChanges) =>
           await FindByCondition(d => d.DepartmentCode.Equals(departmentCode), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateDepartment(Department department) => Create(department);

        public void DeleteDepartment(Department department) => Delete(department);
    }
}
