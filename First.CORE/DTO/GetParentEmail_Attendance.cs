using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.DTO
{
    public class GetParentEmail_Attendance
    {
        public decimal Id { get; set; }
        public decimal? Studentid { get; set; }
        public decimal? Busid { get; set; }
        public DateTime? Dateofattendance { get; set; }
        public decimal? Attendancestatus { get; set; }

        public string Studentname { get; set; }
        public decimal? Parentid { get; set; }
        public string Parentname { get; set; }
        public string Parentemail { get; set; }
        public decimal? Busnumber { get; set; }
    }
}
