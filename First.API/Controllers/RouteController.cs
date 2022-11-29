using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRouteService _routeService;
        public RouteController(IRouteService routeService)
        {
            _routeService = routeService;
        }
        [HttpPost]
        [Route("CreateRoute")]
        public void CreateRoute(Route route)
        {
            _routeService.CreateRoute(route);
        }
        [HttpDelete]
        [Route("DeleteRoute/{id}")]
        public void DeleteRoute(int id)
        {
            _routeService.DeleteRoute(id);
        }
        [HttpGet]
        [Route("GetAllRoute")]
        public List<Route> GetAllRoute()
        {
            return _routeService.GetAllRoute();
        }
        [HttpGet]
        [Route("GetAllRouteDTO")]
        public List<RouteDTO> GetRouteDTO()
        {
            return _routeService.GetAllRouteDTO();
        }

        [HttpGet]
        [Route("GetRouteById/{id}")]
        public Route GetRouteById(int id)
        {
            return _routeService.GetRouteById(id);
        }
        [HttpPut]
        [Route("UpdateRoute")]
        public void UpdateRoute(Route route)
        {
            _routeService.UpdateRoute(route);
        }
    }
}
