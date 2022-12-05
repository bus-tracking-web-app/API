﻿using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [Route("delete/{id}")]
        public void Deleteattendance(int id)
        {
            _attendanceService.Deleteattendance(id);
        }
        [HttpGet]
        public List<AllAttendance> GetAllattendance()
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
        [HttpGet]
        [Route("getStatus")]
        public List<Attendancestatus> GetStatus()
        {
            return _attendanceService.GetStatus();
        }
        [HttpGet]
        [Route("selectgetStatusById/{id}")]
        public Attendancestatus GetStatusById(int id)
        {
            return _attendanceService.GetStatusById(id);
        }

        [HttpGet]
        [Route("getByDate/{dateofattendance}")]
        public List<AllAttendance> GetattendanceByDate(DateTime dateofattendance)
        {
            return _attendanceService.GetattendanceByDate(dateofattendance);
        }

    }
}
