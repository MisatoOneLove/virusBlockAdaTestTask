﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService()
        {
            return new UserService();
        }
    }
}
