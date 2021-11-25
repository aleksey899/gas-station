using Microsoft.AspNetCore.Mvc;

namespace gas_station.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
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