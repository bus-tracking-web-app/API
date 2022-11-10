using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Mvc;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IJWTService _jwtservice;

        public AccountController(IJWTService jwtservice)
        {
            _jwtservice = jwtservice;
        }

        [HttpPost]
        public IActionResult Auth([FromBody] User user)
        {
            var token = _jwtservice.Auth(user);

            if (token == null)
            {
                return Unauthorized("invalid username or password");
            }
            else
            {
                return Ok(token);
            }
        }
    }
}
