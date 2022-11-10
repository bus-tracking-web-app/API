using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Bu
    {
        public Bu()
        {
            Attendances = new HashSet<Attendance>();
            Routes = new HashSet<Route>();
            Students = new HashSet<Student>();
        }

        public decimal Id { get; set; }
        public decimal? Busnumber { get; set; }
        public decimal? Busdriver { get; set; }
        public decimal? Round { get; set; }
        public decimal? Teacher { get; set; }

        public virtual User BusdriverNavigation { get; set; }
        public virtual Roundstatus RoundNavigation { get; set; }
        public virtual User TeacherNavigation { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
