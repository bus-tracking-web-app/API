using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface ITestimonialRepository
    {
        List<Testimonial> GETALLtestimonial();
        Testimonial GETtestimonialBYID(int id);
        void CREATEtestimonial(Testimonial testimonial);
        void UPDATETESTIMONIAL(Testimonial testimonial);
        void Deletetestimonial(int id);
    }
}
