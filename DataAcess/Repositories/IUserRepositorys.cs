using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Identity;

namespace DataAcess
{
    public interface IUserRepository : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        Task SaveAsync();
    }
}
