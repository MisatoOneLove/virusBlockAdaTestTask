using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserModel user);
        Task<ClaimsIdentity> Authenticate(UserModel user);
    }
}
