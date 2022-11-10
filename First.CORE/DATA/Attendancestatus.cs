using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Attendancestatus
    {
        public Attendancestatus()
        {
            Attendances = new HashSet<Attendance>();
        }

        public decimal Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
