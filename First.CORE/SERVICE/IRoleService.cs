using First.CORE.DATA;
using System.Collections.Generic;

namespace First.CORE.SERVICE
{
    public interface IRoleService
    {
        List<Role> GetAllRole();
        void CreateRole(Role role);
        void DeleteRole(int id);
        void UpdateRole(Role role);
        Role GetRoleById(int id);

    }
}
