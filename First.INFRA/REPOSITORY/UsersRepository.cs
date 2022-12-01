using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.REPOSITORY;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace First.INFRA.REPOSITORY
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbContext _dbcontext;

        public UsersRepository(IDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void CreateUser(User user)
        {

            var p = new DynamicParameters();
            p.Add("fullname", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", user.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagepath", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("roleid", user.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbcontext.Connection.Execute("users_package.CreateUser", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("uid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbcontext.Connection.Execute("users_package.DeleteUser", p, commandType: CommandType.StoredProcedure);


        }

        public List<User> GetAllCourse()
        {
            var res = _dbcontext.Connection.Query<User>("users_Package.GetAllUsers", commandType: CommandType.StoredProcedure);
            return res.ToList();


        }

        public List<UserRole> GetAllUsersWithRole()
        {
            var res = _dbcontext.Connection.Query<UserRole>("users_Package.GetAllUsersWithRole", commandType: CommandType.StoredProcedure);
            return res.ToList();

        }

        public User GetByName(string name)
        {
            var p = new DynamicParameters();
            p.Add("name",name, dbType: DbType.String, direction: ParameterDirection.Input);
            var res = _dbcontext.Connection.Query<User>("users_package.GetByName", p, commandType: CommandType.StoredProcedure);
            return res.FirstOrDefault();
        }

        public User GetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("uid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbcontext.Connection.Query<User>("users_package.GetUserById", p, commandType: CommandType.StoredProcedure);
            return res.FirstOrDefault();
        }

        public void UpdateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("userid", user.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("fname", user.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("uemail", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("uname", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("upassword", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("uphone", user.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("uimagepath", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("uroleid", user.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbcontext.Connection.Execute("users_package.UpdateUser", p, commandType: CommandType.StoredProcedure);
        }

        public int ParentCount()
        {

            IEnumerable<int> result = _dbcontext.Connection.Query<int>("USERS_Package.ParentCount", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public int DriverCount()
        {

            IEnumerable<int> result = _dbcontext.Connection.Query<int>("users_package.DriverCount", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public int TeacherCount()
        {

            IEnumerable<int> result = _dbcontext.Connection.Query<int>("users_package.TeacherCount", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
