using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic.Models;
using virusBlockadaTestTask.ViewModels;

namespace virusBlockadaTestTask.Assemblers
{
    public static class CarViewModelAssembler
    {
        public static CarModel FromViewModelToModel(CarViewModel viewModel)
        {
            return new CarModel(viewModel.Model, viewModel.Price, viewModel.Color, viewModel.Year);
        }

        public static CarViewModel FromModelToViewModel(CarModel model)
        {
            return new CarViewModel(model.Model, model.Price, model.Color, model.Year);
        }
    }
}