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
        [Route("uploadImageHome")]
        [HttpPost]
        public Home UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("C:\\Users\\Suzan\\Videos\\Captures\\final project\\Client\\BusTrackingAngular\\src\\assets\\images", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Home item = new Home();
                item.Imagepath = fileName;
                return item;

            }
            catch (Exception e)
            {
                return null;
            }
        }



        [Route("uploadImageHome")]
        [HttpPost]
        public Home UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("C:\\Users\\Suzan\\Client\\BusTrackingAngular\\src\\assets\\images", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Home item = new Home();
                item.Imagepath = fileName;
                return item;

            }
            catch (Exception e)
            {
                return null;
            }
        }



    }

}
