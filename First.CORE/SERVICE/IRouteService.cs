using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
    public interface IRouteService
    {
        List<Route> GetAllRoute();
        Route GetRouteById(int id);
        void CreateRoute(Route route);
        void UpdateRoute(Route route);
        void DeleteRoute(int id);
    }
}
