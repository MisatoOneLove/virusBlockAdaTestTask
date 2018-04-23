using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAcess.Context
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {

        public static ApplicationContext GetInstance()
        {
            return Nested.instance;
        }

        private class Nested
        {
            internal static readonly ApplicationContext instance = 
                new ApplicationContext(Constants.ConnectionString);
        }
        protected ApplicationContext(string conectionString) : base(conectionString)
        {
            Database.SetInitializer<ApplicationContext>(new StoreDbInitializer());
        }

       public DbSet<Car> Cars { get; set; }

    }

}
