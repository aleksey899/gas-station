using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gas_station.Controllers
{
  [ApiController]
  [Route("/admin")]
  public class AdminController : ControllerBase
  {

    [HttpPost("Realize")]
    public string Realize(string str)
    {
        return str;
    }

    [HttpPost("Repair")]
    public string Repair(string str)
    {
        return str;
    }
  }
}

