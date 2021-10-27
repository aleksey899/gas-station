using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gas_station.Controllers
{
    [ApiController]
    [Route("/station")]
    public class StationController : ControllerBase
    {

        [HttpPost("Start")]
        public string Start(string str)
        {
            return str;
        }

        [HttpPost("Error")]
        public string Error(string str)
        {
            return str;
        }
    }
}