using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }



        [HttpPost] 
        public void CreateStudent(Student student)
        {
            _studentService.CreateStudent(student);
        }

        [HttpPut]
        public void UpdateStudent(Student student)
        {
            _studentService.UpdateStudent(student);
        }

        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public void DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
        }

        [HttpGet]
        [Route("Get")]
        public List<Student> GetAllStudent()
        {
            return _studentService.GetAllStudent();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Student GetAllStudentById(int id)
        {
            return _studentService.GetAllStudentById(id);
        }

    }
}
