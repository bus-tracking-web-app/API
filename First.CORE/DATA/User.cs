using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class User
    {
        public User()
        {
            BuBusdriverNavigations = new HashSet<Bu>();
            BuTeacherNavigations = new HashSet<Bu>();
            Students = new HashSet<Student>();
        }

        public decimal Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Imagepath { get; set; }
        public decimal? Roleid { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Bu> BuBusdriverNavigations { get; set; }
        public virtual ICollection<Bu> BuTeacherNavigations { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
