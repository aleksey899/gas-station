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
    public class ClientController1 : ControllerBase
    {
        [HttpPut]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }

        [HttpGet]
        public string ReadInformation(string str)
        {
            return str;
        }

        [HttpPost]
        public string MakeOrder(string str)
        {
            return str;
        }

        [HttpPost]
        public string ServiceRate(string str)
        {
            return str;
        }
    }
}