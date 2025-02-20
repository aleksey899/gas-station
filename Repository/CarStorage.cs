﻿using gas_station.Domain;
using System.Collections.Generic;

namespace gas_station.Repository
{
    public class CarStorage
    {
        private Dictionary<int, Car> Cars { get; } = new Dictionary<int, Car>();

        public void Create(Car car)
        {
            Cars.Add(car.CarId, car);
        }

        public Car Read(int CarId)
        {
            return Cars[CarId];
        }

        public Car Update(int CarId, Car newCar)
        {
            Cars[CarId] = newCar;
            return Cars[CarId];
        }

        public bool Delete(int CarId)
        {
            return Cars.Remove(CarId);
        }
    }
}