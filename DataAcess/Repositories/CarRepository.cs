using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Context;
using DataAcess.Entities;

namespace DataAcess
{
    public class CarRepository : ICarRepository
    {

        private readonly ApplicationContext _database;

        public CarRepository()
        {
            _database = ApplicationContext.GetInstance();
        } 

        public void AddCar(Car car)
        {
            _database.Cars.Add(car);
            _database.SaveChangesAsync();
        }

        public List<Car> GetCars()
        {
            return _database.Cars.ToList();
        }
    }
}
