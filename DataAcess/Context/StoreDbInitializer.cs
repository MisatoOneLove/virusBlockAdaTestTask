using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Entities;

namespace DataAcess.Context
{
    public class StoreDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            db.Cars.Add(new Car("volvo", 200000, "blue", 2009));
            db.Cars.Add(new Car("bmw", 15000, "black", 2010));
            db.Cars.Add(new Car("subary", 30000, "green", 2013));
            db.Cars.Add(new Car("toyota", 15000, "silver", 2010));
            db.Cars.Add(new Car("porshe", 50000, "white", 2017));
            db.SaveChanges();
        }
    }
}
