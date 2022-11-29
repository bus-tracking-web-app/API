using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.DTO
{
    public class AllAttendance
    {
        public decimal Id { get; set; }
        public decimal? Studentid { get; set; }
        public decimal? Busid { get; set; }
        public DateTime? Dateofattendance { get; set; }
        public decimal? Attendancestatus { get; set; }
        public string Sname { get; set; }
        public decimal? Busnumber { get; set; }
        public string Astatus { get; set; }
    }
}
