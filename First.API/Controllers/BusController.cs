using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;
        public BusController(IBusService busService)
        {
            _busService = busService;
        }
        [HttpPost]
        public void CreateBus(Bu bus)
        {
            _busService.CreateBus(bus);
        }
        [HttpDelete]
        public void DeleteBus(int id)
        {
            _busService.DeleteBus(id);
        }
        [HttpGet]
        public List<Bu> GetAllBus()
        {
            return _busService.GetAllBus();
        }
        [HttpGet]
        [Route("getById/{id}")]
        public Bu GetBusById(int id)
        {
            return _busService.GetBusById(id);
        }
        [HttpPut]
        public void UpdateBus(Bu bus)
        {
            _busService.UpdateBus(bus);
        }
    }
}
