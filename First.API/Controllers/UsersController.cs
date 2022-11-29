using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        public void CreateUser(User user)
        {
            _usersService.CreateUser(user);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            _usersService.DeleteUser(id);
        }

        [HttpGet]
        public List<User> GetAllCourse()
        {
            return _usersService.GetAllCourse();
        }

        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return _usersService.GetUserById(id);
        }
        [HttpGet]
        [Route("get/{name}")]
        public User GetUserById(string name)
        {
            return _usersService.GetByName(name);
        }
        [HttpPut]
        public void UpdateUser(User user)
        {
            _usersService.UpdateUser(user);
        }

    }
}
