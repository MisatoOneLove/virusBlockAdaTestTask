using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Assemblers;
using BusinessLogic.Models;
using DataAcess;

namespace BusinessLogic
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }
        public void AddCar(CarModel car)
        {
            _carRepository.AddCar(CarAssembler.FromModelToEntity(car));
        }

        public List<CarModel> GetAllCars()
        {
            return _carRepository.GetCars().Select(CarAssembler.FromEntityToModel).ToList();
        }
    }
}
