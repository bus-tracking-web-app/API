using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace First.INFRA.REPOSITORY
{
    public class HomeRepository : IHomeRepository
    {
        private readonly IDbContext _dbContext;

        public HomeRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CREATEHome(Home home)
        {
            var p = new DynamicParameters();
            p.Add("pImagepath", home.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pTITEL", home.Titel, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pTXT", home.Txt, dbType: DbType.String, direction: ParameterDirection.Input);

            _dbContext.Connection.Execute("Home_package.CREATEHome", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteHome(int id)
        {
            var p = new DynamicParameters();
            p.Add("pHomeid", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Home> result = _dbContext.Connection.Query<Home>("Home_package.DeleteHOME", p, commandType: CommandType.StoredProcedure);
        }

        public List<Home> GetAllHome()
        {
            IEnumerable<Home> result = _dbContext.Connection.Query<Home>("Home_package.GetAllHome", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

       

        public void UPDATHome(Home home)
        {
            var p = new DynamicParameters();
            p.Add("pHomeid", home.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pImagepath", home.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pTITEL", home.Titel, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pTXT", home.Txt, dbType: DbType.String, direction: ParameterDirection.Input);

            _dbContext.Connection.Execute("Home_package.UPDATHOME", p, commandType: CommandType.StoredProcedure);
        }
    }
}
