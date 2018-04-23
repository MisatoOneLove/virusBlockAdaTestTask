using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Entities;

namespace DataAcess
{
    public interface ICarRepository
    {
        List<Car> GetCars();
        void AddCar(Car car);
    }
}
