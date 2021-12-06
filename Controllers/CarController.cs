using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gas_station.Domain;
using gas_station.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gas_station.Controllers
{
    [ApiController]
    [Route("/car")]
    public class CarController1 : ControllerBase
    {
        [HttpPut]
        public Car Create(Car car)
        {
            Storage.CarStorage.Create(car);
            return car;
        }

        [HttpGet]
        public Car Read(int carId)
        {
            return Storage.CarStorage.Read(carId);
        }

        [HttpPatch]
        public Car Update(int carId, Car newCar)
        {
            return Storage.CarStorage.Update(carId, newCar);
        }

        [HttpDelete]
        public bool Delete(int carId)
        {
            return Storage.CarStorage.Delete(carId);
        }
    }
}
        