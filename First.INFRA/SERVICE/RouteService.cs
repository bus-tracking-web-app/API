using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;
        public RouteService(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public void CreateRoute(Route route)
        {
            _routeRepository.CreateRoute(route);
        }

        public void DeleteRoute(int id)
        {
            _routeRepository.DeleteRoute(id);
        }

        public List<Route> GetAllRoute()
        {
            return _routeRepository.GetAllRoute();
        }

        public Route GetRouteById(int id)
        {
            return _routeRepository.GetRouteById(id);
        }

        public void UpdateRoute(Route route)
        {
            _routeRepository.UpdateRoute(route);
        }
    }
}
