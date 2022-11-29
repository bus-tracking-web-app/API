using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
    public interface ITestimonialService
    {
        List<Testimonial> GETALLtestimonial();
        List<TestimonialDTO> GETALLtestimonialDTO();
        List<Testimonialstatus> GETALLtestimonialStatus();
        Testimonialstatus GETtestimonialStatusBYID(int id);

        Testimonial GETtestimonialBYID(int id);
        void CREATEtestimonial(Testimonial testimonial);
        void UPDATETESTIMONIAL(Testimonial testimonial);
        void Deletetestimonial(int id);
    }
}
