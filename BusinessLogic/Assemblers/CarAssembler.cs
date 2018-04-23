using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BusinessLogic.Models;
using DataAcess.Entities;

namespace BusinessLogic.Assemblers
{
    public static class CarAssembler
    {
        public static Car FromModelToEntity(CarModel model)
        {
            return new Car(model.Model, model.Price, model.Color, model.Year);
        }

        public static CarModel FromEntityToModel(Car entity)
        {
            return new CarModel(entity.Model, entity.Price, entity.Color, entity.Year);
        }

    }   
}