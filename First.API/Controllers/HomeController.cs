using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IHomeService _homeService;


        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }


        [HttpPost]

        public void CREATEHome(Home home)
        {
            _homeService.CREATEHome(home);
        }

        [HttpPut]
        public void UPDATHome(Home home)
        {
            _homeService.UPDATHome(home);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteHome(int id)
        {
            _homeService.DeleteHome(id);
        }

        [HttpGet]
        [Route("Get")]
        public List<Home> GetAllHome()
        {
            return _homeService.GetAllHome();
        }

     



    }

}
