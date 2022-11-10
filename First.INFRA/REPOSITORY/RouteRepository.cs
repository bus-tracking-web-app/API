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
    public class RouteRepository : IRouteRepository
    {
        private readonly IDbContext _dbContext;
        public RouteRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateRoute(Route route)
        {
            var p = new DynamicParameters();
            p.Add("pXCURRENT", route.Xcurrent, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pYCURRENT", route.Ycurrent, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pXSTART", route.Xstart, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pYSTART", route.Ystart, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pXEND", route.Xend, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pYEND", route.Yend, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pBUSID", route.Busid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("route_package.CREATEroute", p, commandType: CommandType.StoredProcedure);


        }

        public void DeleteRoute(int id)
        {
            var p = new DynamicParameters();
            p.Add("prouteid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("route_package.deleteroute", p, commandType: CommandType.StoredProcedure);
        }

        public List<Route> GetAllRoute()
        {
            IEnumerable<Route> result = _dbContext.Connection.Query<Route>("route_package.getallroute", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Route GetRouteById(int id)
        {
            var p = new DynamicParameters();
            p.Add("prouteid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Route> result = _dbContext.Connection.Query<Route>("route_package.getroutebyID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();


        }

        public void UpdateRoute(Route route)
        {
            var p = new DynamicParameters();
            p.Add("prouteid", route.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pXCURRENT", route.Xcurrent, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pYCURRENT", route.Ycurrent, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pXSTART", route.Xstart, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pYSTART", route.Ystart, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pXEND", route.Xend, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pYEND", route.Yend, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pBUSID", route.Busid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("route_package.UPDATEroute", p, commandType: CommandType.StoredProcedure);


        }
    }
}
