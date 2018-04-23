using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic
{
    public interface ICarService
    {
        List<CarModel> GetAllCars();
        void AddCar(CarModel car);
    }
}
