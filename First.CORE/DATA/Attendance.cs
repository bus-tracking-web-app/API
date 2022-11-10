using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Attendance
    {
        public decimal Id { get; set; }
        public decimal? Studentid { get; set; }
        public decimal? Busid { get; set; }
        public DateTime? Dateofattendance { get; set; }
        public decimal? Attendancestatus { get; set; }

        public virtual Attendancestatus AttendancestatusNavigation { get; set; }
        public virtual Bu Bus { get; set; }
    }
}
