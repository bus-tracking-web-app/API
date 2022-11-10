using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Testimonialstatus
    {
        public Testimonialstatus()
        {
            Testimonials = new HashSet<Testimonial>();
        }

        public decimal Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
