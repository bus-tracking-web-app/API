using First.CORE.DATA;
using First.CORE.SERVICE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace First.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundController : ControllerBase
    {

        private readonly IRoundService _roundService;
        public RoundController(IRoundService roundService)
        {
            _roundService = roundService;
        }


        [HttpGet]
        [Route("Get")]
        public List<Roundstatus> GetAllRound()
        {
            return _roundService.GetAllRound();
        }


        [HttpGet]
        [Route("GetById/{id}")]
        Roundstatus GetRoundByID(int id)
        {
            return _roundService.GetRoundByID(id);
        }
    }
}
