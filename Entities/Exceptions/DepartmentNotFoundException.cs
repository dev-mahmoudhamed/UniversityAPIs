
namespace Entities.Exceptions
{
    public sealed class DepartmentNotFoundException : NotFoundException
    {
        public DepartmentNotFoundException(string departmentCode)
            : base($"Department with id: {departmentCode} doesn't exist in the database.")
        { 
        }
    }
}
