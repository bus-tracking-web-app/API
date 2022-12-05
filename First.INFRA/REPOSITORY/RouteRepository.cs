using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.REPOSITORY;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Route = First.CORE.DATA.Route;

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
            p.Add("pXCURRENT", "null", dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pYCURRENT", "null", dbType: DbType.Int32, direction: ParameterDirection.Input);
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

        public List<RouteDTO> GetAllRouteDTO()
        {
            IEnumerable<RouteDTO> result = _dbContext.Connection.Query<RouteDTO>("route_package.getAllRouteDTO", commandType: CommandType.StoredProcedure);
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
        public Route GetBusRouteByDriverId(int driverId)
        {
            var p = new DynamicParameters();
            p.Add("driverId", driverId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Route> result = _dbContext.Connection.Query<Route>("getbusRouteByuserId", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();


        }
        public void SetBusLocation(SetBusLocationDTO setBusLocation)
        {
            var p = new DynamicParameters();
            p.Add("latx", setBusLocation.Xcurrent, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("longy", setBusLocation.Ycurrent, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("driverId", setBusLocation.DriverId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("SETCURRENTBUSLOCATION", p, commandType: CommandType.StoredProcedure);

        }
         public void SetCureenBusLocationAftreEnf(int driverId)
        {
            var p = new DynamicParameters();
            p.Add("driverId", driverId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("setCurrentBusLocationAfterEnd", p, commandType: CommandType.StoredProcedure);


        }

    }
}
