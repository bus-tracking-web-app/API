using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;
        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }
        [HttpPost]
        public void Createattendance(Attendance attendance)
        {
            _attendanceService.Createattendance(attendance);
        }
        [HttpDelete]
        public void Deleteattendance(int id)
        {
            _attendanceService.Deleteattendance(id);
        }
        [HttpGet]
        public List<Attendance> GetAllattendance()
        {
            return _attendanceService.GetAllattendance();
        }
        [HttpGet]
        [Route("GetByStudentId/{id}")]
        public Attendance GetattendanceByStudentId(int id)
        {
            return _attendanceService.GetattendanceByStudentId(id);
        }
        [HttpPut]
        public void Updateattendance(Attendance attendance)
        {
            _attendanceService.Updateattendance(attendance);
        }
    }
}
