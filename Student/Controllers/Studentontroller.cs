using Microsoft.AspNetCore.Mvc;
using Student.Model;
using Student.Provider;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentProvider _studentProvider;

        public StudentController(IStudentProvider studentProvider)
        {
            _studentProvider = studentProvider;
        }

        [HttpGet("M")]
        public IEnumerable<StudentModel> GetGradeMuoi()
        {
            return _studentProvider.GetStudents(10);
        }

        [HttpGet("MM")]
        public IEnumerable<StudentModel> GetGradeMuoiMot()
        {
            return _studentProvider.GetStudents(11);
        }

        [HttpGet("MH")]
        public IEnumerable<StudentModel> GetGradeMuoiHai()
        {
            return _studentProvider.GetStudents(12);
        }

    }
}
