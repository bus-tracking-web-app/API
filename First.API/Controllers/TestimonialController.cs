using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

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
        [Route("GETALLtestimonialDTO")]
        public List<TestimonialDTO> GETALLtestimonialDTO()
        {
            return _testimonialService.GETALLtestimonialDTO();
        }
        [HttpGet]
        [Route("GETALLtestimonialStatus")]
        public List<Testimonialstatus> GetTestimonialStatus()
        {
            return _testimonialService.GETALLtestimonialStatus();
        }


        [HttpGet]
        [Route("GETtestimonialBYID/{id}")]
        public Testimonial GETtestimonialBYID(int id)
        {
            return _testimonialService.GETtestimonialBYID(id);
        }

        [HttpGet]
        [Route("GETtestimonialStatusBYID/{id}")]
        public Testimonialstatus GETtestimonialStatusBYID(int id)
        {
            return _testimonialService.GETtestimonialStatusBYID(id);
        }

        [HttpPut]
        [Route("UPDATETESTIMONIAL")]
        public void UPDATETESTIMONIAL(Testimonial testimonial)
        {
            _testimonialService.UPDATETESTIMONIAL(testimonial);
        }
        [Route("uploadImage")]
        [HttpPost]
        public Testimonial UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Qais\\Desktop\\client 11-26-2022\\Client\\BusTrackingAngular\\src\\assets\\images\\testimonial", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Testimonial item = new Testimonial();
            item.Imagepath = fileName;
            return item;
        }
        [HttpGet]
        [Route("getApprovedTestimonial")]
        public List<Testimonial> getApprovedTestimonial()
        {
            return _testimonialService.getApprovedTestimonial();
        }

        [HttpGet]
        [Route("getTestimonialByUserName/{username}")]
        public bool getTestimonialByName(string username)
        {
            var res = _testimonialService.getTestimonialByName(username).Count;
            if (res >= 1) return true;

            else return false;
        }

    }
}
