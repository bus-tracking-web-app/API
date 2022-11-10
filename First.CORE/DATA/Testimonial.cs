using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Testimonial
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Imagepath { get; set; }
        public string Feedback { get; set; }
        public decimal? Statusid { get; set; }

        public virtual Testimonialstatus Status { get; set; }
    }
}
