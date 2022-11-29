using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;
        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }
        [HttpPost]
        [Route("CREATEshcool")]
        public void CREATEshcool(School school)
        {
            _schoolService.CREATEshcool(school);
        }
        [HttpDelete]
        [Route("deleteshcool/{id}")]
        public void deleteshcool(int id)
        {
            _schoolService.deleteshcool(id);
        }
        [HttpGet]
        [Route("getAllSchool")]
        public List<School> getAllSchool()
        {
            return _schoolService.getAllSchool();
        }
        [HttpPut]
        [Route("UPDATEshcool")]
        public void UPDATEshcool(School school)
        {
            _schoolService.UPDATEshcool(school);
        }
        [Route("uploadImage")]
        [HttpPost]
        public School UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Qais\\Desktop\\client 11-26-2022\\Client\\BusTrackingAngular\\src\\assets\\images\\school", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            School item = new School();
            item.Logo = fileName;
            return item;
        }

    }
}
