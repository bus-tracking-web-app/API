using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.DTO
{
 public class AllInformationOfStudent
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

        public decimal? Busnumber { get; set; }
        public string Parent { get; set; }
        public string roundstatus { get; set; }


    }
}
