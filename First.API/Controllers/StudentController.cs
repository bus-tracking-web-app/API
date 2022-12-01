using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

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
        public List<AllInformationOfStudent> GetAllStudent()
        {
            return _studentService.GetAllStudent();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Student GetAllStudentById(int id)
        {
            return _studentService.GetAllStudentById(id);
        }

        [HttpGet]
        [Route("studentcount")]
        public int StudentCount()
        {
            //return _studentService.StudentCount();
            return _studentService.StudentCount();
        }

        [Route("uploadImage")]
        [HttpPost]
        public Student UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("C:\\Users\\Suzan\\Client\\BusTrackingAngular\\src\\assets\\images\\Students", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Student item = new Student();
                item.Imgpath = fileName;
                return item;

            }
            catch (Exception e)
            {
                return null;
            }
        }



    }
}
