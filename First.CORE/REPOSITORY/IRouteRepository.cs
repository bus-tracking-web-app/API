using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IRouteRepository
    {
        List<Route> GetAllRoute();
        List<RouteDTO> GetAllRouteDTO();

        Route GetRouteById(int id);
        void CreateRoute(Route route);
        void UpdateRoute(Route route);
        void DeleteRoute(int id);
    }
}
