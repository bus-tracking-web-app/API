using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.DTO
{
    public class RouteDTO
    {
        public decimal Id { get; set; }
        public string Xcurrent { get; set; }
        public string Ycurrent { get; set; }
        public string Xstart { get; set; }
        public string Ystart { get; set; }
        public string Xend { get; set; }
        public string Yend { get; set; }
        public decimal? Busid { get; set; }
        public string Fullname { get; set; }
        public decimal? Busnumber { get; set; }



    }
}
