using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
    }
}
