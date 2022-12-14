using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.SERVICE;
using MailKit.Net.Smtp;
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
        public List<AllAttendance> GetattendanceByStudentId(int id)
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
        [Route("getByDate/{dateofattendance}/{tid}")]
        public List<AllAttendance> GetattendanceByDate(DateTime dateofattendance, int tid)
        {
            return _attendanceService.GetattendanceByDate(dateofattendance, tid);
        }


        [HttpGet]
        [Route("StudentInfo/{dateofday}/{tid}")]
        public List<GetParentEmail_Attendance> GetParentEmail(DateTime dateofday, int tid)
        {
            return _attendanceService.GetParentEmail(dateofday, tid);
        }



        [HttpGet]
        [Route("SendEmail/{ParentEmail}")]
        public void SendEmail(String ParentEmail)
        {
            var builder = new BodyBuilder();

            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Bus Tracking", "s.moe12@yahoo.com");
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress("User", ParentEmail);
            message.To.Add(to);
            message.Subject = "Bus Tracking";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = string.Format(
            "<h4 style=\"text-align: center;color:#7fb685\" >Thank you for trusting us !!</h4>" + "" +
            "<p>Your son Near of you </p>");
            message.Body = bodyBuilder.ToMessageBody();
            using (var clinte = new SmtpClient())
            {
                clinte.Connect("smtp.mail.yahoo.com", 465, true);
                clinte.Authenticate("s.moe12@yahoo.com", "rxlhovtglvjibneg");
                clinte.Send(message);
                clinte.Disconnect(true);
            }


        }
        [HttpPost]
        [Route("Search")]
        public List<AllAttendance> Search(SearchAtt searchAtt)
        {
            return _attendanceService.Search(searchAtt);
        }
    }




}





