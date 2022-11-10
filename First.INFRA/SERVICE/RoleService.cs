using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System.Collections.Generic;

namespace First.INFRA.SERVICE
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _RoleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _RoleRepository = roleRepository;
        }

        public void CreateRole(Role role)
        {
            _RoleRepository.CreateRole(role);
        }

        public void DeleteRole(int id)
        {
            _RoleRepository.DeleteRole(id);
        }

        public List<Role> GetAllRole()
        {
            return _RoleRepository.GetAllRole();
        }

        public Role GetRoleById(int id)
        {
            return _RoleRepository.GetRoleById(id);
        }

        public void UpdateRole(Role role)
        {
            _RoleRepository.UpdateRole(role);
        }
    }
}
