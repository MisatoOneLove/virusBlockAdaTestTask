using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Context;
using DataAcess.Entities;
using DataAcess.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAcess
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationUserManager _userManager;
        private readonly ApplicationContext _database;

        public UserRepository()
        {
            _database = ApplicationContext.GetInstance();
            _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(ApplicationContext.GetInstance()));
        }

        public async Task SaveAsync()
        {
            await _database.SaveChangesAsync();
        }


        public ApplicationUserManager UserManager => _userManager;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed;

        public virtual void Dispose(bool disposing)
        {
            if (this.disposed) return;
            if (disposing)
            {
                _userManager.Dispose();
            }
            this.disposed = true;
        }
    }
}
