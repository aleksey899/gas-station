using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gas_station.Controllers
{
  [ApiController]
  [Route("/client")]
  public class ClientController : ControllerBase
  {

    [HttpGet("Information")]
    public string Information(string str)
    {
        return str;
    }

    [HttpPost("Making")]
    public string Makinп(string str)
    {
        return str;
    }

    [HttpPost("Evaluation")]
    public string Evaluation(string str)
    {
        return str;
    }

    [HttpGet("Price")]
    public string Price(string str)
    {
        return str;
    }

    [HttpGet("Sale")]
    public string Sale(string str)
    {
        return str;
    }

    [HttpPost("Fuel")]
    public string Fuel(string str)
    {
        return "str";
    }

    [HttpPost("Loyalty")]
    public string Loyalty(string str)
    {
        return str;
    }

    [HttpPost("Payment")]
    public string Payment(string str)
    {
        return str;
    }
  }
}

