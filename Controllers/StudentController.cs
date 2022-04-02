using Microsoft.AspNetCore.Mvc;
using wepAPI.Data;

namespace wepAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentsContext _Context;
        public StudentController(StudentsContext context)
        {
            _Context = context;
        }
    }
}
