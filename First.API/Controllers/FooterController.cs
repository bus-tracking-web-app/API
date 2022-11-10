using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController : ControllerBase
    {
        private readonly IFooterService _footerService;
        public FooterController(IFooterService footerService)
        {
            _footerService = footerService;
        }
        [HttpPost]
        public void CreateFooter(Footer footer)
        {
            _footerService.CreateFooter(footer);
        }
        [HttpDelete]
        public void DeleteFooter(int id)
        {
            _footerService.DeleteFooter(id);
        }
        [HttpGet]
        public List<Footer> GetAllFooter()
        {
            return _footerService.GetAllFooter();
        }

        [HttpPut]
        public void UpdateFooter(Footer footer)
        {
            _footerService.UpdateFooter(footer);
        }
    }
}
