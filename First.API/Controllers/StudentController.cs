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
        [Route("GetStudentByParentId/{Parent_ID}")]
        public List<Student> GetStudentByParentId(int Parent_ID)
        {
            return _studentService.GetStudentByParentId(Parent_ID);
        }

        [HttpGet]
        [Route("GetStudentByBusId/{Bus_ID}")]
        public List<Student> GetStudentByBusId(int Bus_ID)
        {
            return _studentService.GetStudentByBusId(Bus_ID);
        }




        [HttpGet]
        [Route("GetById/{id}")]
        public Student GetAllStudentById(int id)
        {
            return _studentService.GetAllStudentById(id);
        }
        [Route("uploadImage")]
        [HttpPost]
        public Student UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("C:\\Users\\Suzan\\Videos\\Captures\\final project\\Client\\BusTrackingAngular\\src\\assets\\images", fileName);

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
        [Route("UpdateStudentBusStatus/{lathome}")]
        [HttpGet]
        public void UpdateStudentBusStatus(string lathome)
        {
            _studentService.UpdateStudentBusStatus(lathome);
        }
        [Route("UpdateAllStudentStatus")]
        [HttpGet]

        public void UpdateAllStudentStatus()
        {
            _studentService.UpdateAllStudentStatus();
        }

        [Route("getParentStudents/{id}")]
        [HttpGet]

        public List<ParentStudentDTO> getParentStudents(int id)
        {
            return _studentService.getParentStudents(id);
        }



    }
}
