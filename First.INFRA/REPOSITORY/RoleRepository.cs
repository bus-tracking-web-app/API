using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.REPOSITORY;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace First.INFRA.REPOSITORY
{
    public class RoleRepository : IRoleRepository
    {

        private readonly IDbContext _dbContext;

        public RoleRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("rname", role.Rolename, dbType: DbType.String, direction: ParameterDirection.Input);
            var res = _dbContext.Connection.Execute("role_package.Createrole", p, commandType: CommandType.StoredProcedure);


        }

        public void DeleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("rid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbContext.Connection.Execute("role_package.Deleterole", p, commandType: CommandType.StoredProcedure);


        }

        public List<Role> GetAllRole()
        {
            var res = _dbContext.Connection.Query<Role>("role_package.GetAllRole", commandType: CommandType.StoredProcedure);
            return res.ToList();


        }

        public Role GetRoleById(int id)
        {
            var p = new DynamicParameters();
            p.Add("rid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbContext.Connection.Query<Role>("role_package.GetRoleById", p, commandType: CommandType.StoredProcedure);
            return res.FirstOrDefault();

        }



        public void UpdateRole(Role role)
        {

            var p = new DynamicParameters();
            p.Add("rid", role.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("rname", role.Rolename, dbType: DbType.String, direction: ParameterDirection.Input);
            var res = _dbContext.Connection.Execute("role_package.Updaterole", p, commandType: CommandType.StoredProcedure);
        }
    }
}
