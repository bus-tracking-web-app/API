using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.SERVICE;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
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


        [HttpGet]
        [Route("StudentInfo/{dateofday}")]
        public List<GetParentEmail_Attendance> GetParentEmail(DateTime dateofday)
        {
            return _attendanceService.GetParentEmail(dateofday);
        }



        [HttpGet]
        [Route("SendEmail/{ParentEmail}")]
        public void SendEmail(String ParentEmail)
        {


            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Bus Tracking", "s.moe12@yahoo.com");
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress("User", ParentEmail);
            message.To.Add(to);
            message.Subject = "Your son Near of you";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody =
            "<p style=\"color:#7fb685\">quastion approve </p>" + "The Date"  + "<p> Thank you for trusting us </p>" + "<p>Your son </p>";
            message.Body = bodyBuilder.ToMessageBody();
            using (var clinte = new SmtpClient())
            {
                clinte.Connect("smtp.mail.yahoo.com", 465, true);
                clinte.Authenticate("s.moe12@yahoo.com", "rxlhovtglvjibneg");
                clinte.Send(message);
                clinte.Disconnect(true);
            }


        }
    }




                
         
}


