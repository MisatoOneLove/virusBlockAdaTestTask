using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic.Models;
using virusBlockadaTestTask.ViewModels;

namespace virusBlockadaTestTask.Assemblers
{
    public static class UserViewModelAssembler
    {
        public static UserModel FromViewModelToModel(UserViewModel viewModel)
        {
            return new UserModel(viewModel.Username, viewModel.Password);
        }

        public static UserViewModel FromModelToViewModel(UserModel model)
        {
            return new UserViewModel(model.Username, model.Password);
        }
    }
}