using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.REPOSITORY;
using System.Data;
using System.Linq;

namespace First.INFRA.REPOSITORY
{
    public class JWTRepository : IJWTRepository
    {

        private readonly IDbContext _dBContext;

        public JWTRepository(IDbContext dBContext)
        {
            _dBContext = dBContext;
        }

        public User Auth(User user)
        {
            var p = new DynamicParameters();
            p.Add("uname", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("upass", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var res = _dBContext.Connection.Query<User>("users_Package.UserLogin", p, commandType: CommandType.StoredProcedure);
            return res.FirstOrDefault();
        }
    }
}
