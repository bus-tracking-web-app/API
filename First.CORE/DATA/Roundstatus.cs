using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Roundstatus
    {
        public Roundstatus()
        {
            Bus = new HashSet<Bu>();
            Students = new HashSet<Student>();
        }

        public decimal Id { get; set; }
        public string Roundstatus1 { get; set; }

        public virtual ICollection<Bu> Bus { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
