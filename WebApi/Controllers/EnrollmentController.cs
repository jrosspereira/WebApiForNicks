using Lesgo.Data;
using Lesgo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrollmentController : ControllerBase
    {
        private readonly ILogger<EnrollmentController> _logger;
        private readonly IStudentService _studentService;

        public EnrollmentController(ILogger<EnrollmentController> logger, 
            IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpPost(Name = "Enroll")]
        public JsonResult Enroll(EnrollStudent enrollStudent)
        {
            _studentService.EnrollStudent(new Student
            {
                FirstName = enrollStudent.StudentFirstName,
                LastName = enrollStudent.StudentLastName
            }, enrollStudent.SubjectIds);

            return new JsonResult(true);
        }
    }
}