using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Student
    {
        public decimal Id { get; set; }
        public string Fullname { get; set; }
        public string Imgpath { get; set; }
        public string Xhome { get; set; }
        public string Yhome { get; set; }
        public string Inbusstatus { get; set; }
        public decimal? Round { get; set; }
        public decimal? Parentid { get; set; }
        public decimal? Busid { get; set; }

        public virtual Bu Bus { get; set; }
        public virtual User Parent { get; set; }
        public virtual Roundstatus RoundNavigation { get; set; }
    }
}
