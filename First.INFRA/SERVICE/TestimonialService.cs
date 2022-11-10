using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;
        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }
        public void CREATEtestimonial(Testimonial testimonial)
        {
            _testimonialRepository.CREATEtestimonial(testimonial);
        }

        public void Deletetestimonial(int id)
        {
            _testimonialRepository.Deletetestimonial(id);

        }

        public List<Testimonial> GETALLtestimonial()
        {
            return _testimonialRepository.GETALLtestimonial();
        }

        public Testimonial GETtestimonialBYID(int id)
        {
            return _testimonialRepository.GETtestimonialBYID(id);
        }

        public void UPDATETESTIMONIAL(Testimonial testimonial)
        {
            _testimonialRepository.UPDATETESTIMONIAL(testimonial);
        }
    }
}
