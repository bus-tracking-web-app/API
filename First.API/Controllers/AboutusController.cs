using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutusController : ControllerBase
    {

        private readonly IAboutusService _aboutusService;
        public AboutusController (IAboutusService aboutusService)
        {
            _aboutusService = aboutusService;
        }

        [HttpPost]

        public void CREATEABOUTUS(Aboutu aboutu)
        {
            _aboutusService.CREATEABOUTUS(aboutu);
        }

        [HttpPut]
        public void UPDATABOUTUS(Aboutu aboutu)
        {
            _aboutusService.UPDATABOUTUS(aboutu);
        }

        [HttpDelete]
        [Route("DeleteAboutUs/{id}")]
        public void DeleteABOUTUS(int id)
        {
            _aboutusService.DeleteABOUTUS(id);
        }

        [HttpGet]
        [Route("Get")]
        public List<Aboutu> GetAllAbout()
        {
            return _aboutusService.GetAllAbout();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Aboutu GetAboutByID(int id)
        {
            return _aboutusService.GetAboutByID(id);
        }

    }
}
