using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        private readonly IRoleService _RoleService;
        public RoleController(IRoleService RoleService)
        {
            _RoleService = RoleService;
        }

        [HttpPost]
        public void CreateRole(Role role)
        {
            _RoleService.CreateRole(role);
        }

        [HttpDelete("{id}")]
        public void DeleteRole(int id)
        {
            _RoleService.DeleteRole(id);
        }

        [HttpGet]
        public List<Role> GetAllRole()
        {
            return _RoleService.GetAllRole();
        }

        [HttpGet("{id}")]
        public Role GetRoleById(int id)
        {
            return _RoleService.GetRoleById(id);
        }
        [HttpPut]
        public void UpdateRole(Role role)
        {
            _RoleService.UpdateRole(role);
        }

    }
}
