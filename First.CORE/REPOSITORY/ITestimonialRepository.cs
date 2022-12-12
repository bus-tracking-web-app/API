using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface ITestimonialRepository
    {
        List<Testimonial> GETALLtestimonial();
        List<Testimonialstatus> GETALLtestimonialStatus();
        
        List<TestimonialDTO> GETALLtestimonialDTO();
        Testimonialstatus GETtestimonialStatusBYID(int id);

        Testimonial GETtestimonialBYID(int id);
        void CREATEtestimonial(Testimonial testimonial);
        void UPDATETESTIMONIAL(Testimonial testimonial);
        void Deletetestimonial(int id);
        List<Testimonial> getApprovedTestimonial();
        List<Testimonial> getTestimonialByName(String username);
    }
}
