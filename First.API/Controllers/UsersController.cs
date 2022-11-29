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
        public User GetUserByName(string name)
        {
            return _usersService.GetByName(name);
        }
        [HttpPut]
        public void UpdateUser(User user)
        {
            _usersService.UpdateUser(user);
        }
        [Route("uploadImage")]
        [HttpPost]
        public User UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("D:\\AngularTutorial\\Client1\\Client\\BusTrackingAngular\\src\\assets\\images\\users", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            User item = new User();
            item.Imagepath = fileName;
            return item;
        }

        [Route("userwithrole")]
        [HttpGet]
        public List<UserRole> GetAllUsersWithRole()
        {
            return _usersService.GetAllUsersWithRole();
        }



    }
}
