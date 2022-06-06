namespace Service.Contracts
{
    public interface IServiceManager
    {
        ICourseService CourseService { get; }
        IStudentService StudentService { get; }
        IDepartmentService DepartmentService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
