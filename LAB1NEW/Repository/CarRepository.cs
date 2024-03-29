﻿using LAB1NEW.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LAB1NEW.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(Car car) => CarManagement.Instance.Remove(car);

        public Car GetCarByID(int carId) => CarManagement.Instance.GetCarByID(carId);

        public IEnumerable<Car> GetCars() => CarManagement.Instance.GetCarsList();

        public void InsertCar(Car car) => CarManagement.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarManagement.Instance.Update(car);
    }
}
