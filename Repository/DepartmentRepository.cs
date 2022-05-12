using Contracts;
using Entities.Models;

namespace Repository
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public IEnumerable<Department> GetDepartments(bool trackChanges) => FindAll(trackChanges).ToList();



        public Department GetDepartment(string DepartmentCode, bool trackChanges) =>
            FindByCondition(d => d.DepartmentCode.Equals(DepartmentCode), trackChanges)
            .SingleOrDefault();
     }
}
