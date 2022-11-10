using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpPost]
        [Route("CREATEtestimonial")]
        public void CREATEtestimonial(Testimonial testimonial)
        {
            _testimonialService.CREATEtestimonial(testimonial);
        }
        [HttpDelete]
        [Route("Deletetestimonial/{id}")]
        public void Deletetestimonial(int id)
        {
            _testimonialService.Deletetestimonial(id);

        }
        [HttpGet]
        [Route("GETALLtestimonial")]
        public List<Testimonial> GETALLtestimonial()
        {
            return _testimonialService.GETALLtestimonial();
        }
        [HttpGet]
        [Route("GETtestimonialBYID/{id}")]
        public Testimonial GETtestimonialBYID(int id)
        {
            return _testimonialService.GETtestimonialBYID(id);
        }
        [HttpPut]
        [Route("UPDATETESTIMONIAL")]
        public void UPDATETESTIMONIAL(Testimonial testimonial)
        {
            _testimonialService.UPDATETESTIMONIAL(testimonial);
        }

    }
}
