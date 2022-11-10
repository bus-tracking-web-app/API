using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpPost]
        public void CreateContact(Contactu contact)
        {
            _ContactService.CreateContact(contact);
        }
        /*
        [HttpDelete("{id}")]
        public void DeleteContact(int id)
        {
            _ContactService.DeleteContact(id);
        }
        */
        [HttpGet]
        public List<Contactu> GetAllRole()
        {
            return _ContactService.GetAllRole();
        }

        [HttpGet("{id}")]
        public Contactu GetContactById(int id)
        {
            return _ContactService.GetContactById(id);
        }



    }
}
