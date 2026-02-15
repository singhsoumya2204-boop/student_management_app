using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemAPI.Services;
using StudentManagementSystemAPI.Models;

namespace StudentManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService service;

        public StudentController(StudentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = service.GetAllStudents();
            return Ok(students);
        }
    }
}
