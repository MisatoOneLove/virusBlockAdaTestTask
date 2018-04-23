using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;
using DataAcess;
using DataAcess.Entities;
using Microsoft.AspNet.Identity;

namespace BusinessLogic
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public async Task<ClaimsIdentity> Authenticate(UserModel userModel)
        {
            ClaimsIdentity claim = null;
            // находим пользователя
            ApplicationUser user = await _userRepository.UserManager.FindAsync(userModel.Username, userModel.Password);
            // авторизуем его и возвращаем объект ClaimsIdentity
            if (user != null)
                claim = await _userRepository.UserManager.CreateIdentityAsync(user,
                    DefaultAuthenticationTypes.ApplicationCookie);
            return claim;
        }

        public async Task<OperationDetails> Create(UserModel userModel)
        {
            var user = await _userRepository.UserManager.FindByNameAsync(userModel.Username);
            if (user != null)
                return new OperationDetails(false, "Пользователь с таким логином уже существует", "Email");
            user = new ApplicationUser { UserName = userModel.Username, PasswordHash = userModel.Password};
            var result = await _userRepository.UserManager.CreateAsync(user, userModel.Password);
            if (result.Errors.Any())
                return new OperationDetails(false, result.Errors.FirstOrDefault(), "");

            await _userRepository.SaveAsync();
            return new OperationDetails(true, "Регистрация успешно пройдена", "");
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}
