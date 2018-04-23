using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;
using DataAcess.Entities;

namespace BusinessLogic.Assemblers
{
    public static class UserAssembler
    {
        public static UserModel FromEntityToModel(ApplicationUser user)
        {
            return new UserModel( user.UserName, user.PasswordHash);
        }
    }
}
