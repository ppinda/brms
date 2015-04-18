using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BRMS.Model.Entities;

namespace BRMS.Data
{
    class DbInitializer : DropCreateDatabaseAlways<BRMSDbContext>
    {
        protected override void Seed(BRMSDbContext context)
        {
            // Create customers
            var customer1 = new Customer { FirstName = "John", LastName = "Doe", Email = "john@doe.com", Password = "123", Id = 1 };
            var customer2 = new Customer { FirstName = "Andrew", LastName = "Dean", Email = "andrewdean@gmail.com", Password = "123", Id = 2 };
            var customer3 = new Customer { FirstName = "Jackie", LastName = "Smith", Email = "smith_jackie@me.com", Password = "123", Id = 3 };
            context.Customers.Add(customer1);
            context.Customers.Add(customer2);
            context.Customers.Add(customer3);

            // Create mechanics
            var mechanic1 = new Mechanic { FirstName = "Lisa", LastName = "Atkins", Email = "latkins@me.com", Password = "123", Id = 1 };
            var mechanic2 = new Mechanic { FirstName = "Tom", LastName = "Meazzo", Email = "tom@meazzo.com", Password = "123", Id = 2 };
            context.Mechanics.Add(mechanic1);
            context.Mechanics.Add(mechanic2);

            // Create manager
            var manager = new Manager { FirstName = "Brian", LastName = "Simpson", Email = "brian@simpson.com", Password = "123", Id = 1 };
            context.Managers.Add(manager);

            // Create service activities
            var activity1 = new ServiceActivity { Name = "Change tyres", Id = 1 };
            var activity2 = new ServiceActivity { Name = "Replace breaks", Id = 2 };
            var activity3 = new ServiceActivity { Name = "Repaint", Id = 3 };
            context.ServiceActivities.Add(activity1);
            context.ServiceActivities.Add(activity2);
            context.ServiceActivities.Add(activity3);

            // Create service packages
            var package1 = new ServicePackage { Name = "Starter", Price = 25, Id = 1 };
            package1.ServiceActivities.Add(activity1);
            var package2 = new ServicePackage { Name = "Combo", Price = 50, Id = 2 };
            package2.ServiceActivities.Add(activity1);
            package2.ServiceActivities.Add(activity2);
            var package3 = new ServicePackage { Name = "Mighty", Price = 75, Id = 3 };
            package3.ServiceActivities.Add(activity1);
            package3.ServiceActivities.Add(activity2);
            package3.ServiceActivities.Add(activity3);
            context.ServicePackages.Add(package1);
            context.ServicePackages.Add(package2);
            context.ServicePackages.Add(package3);

            // Create services
            var service1 = new Service { Customer = customer1, DropOffDate = DateTime.Now.AddDays(1), Mechanic = mechanic1, PickUpDate = DateTime.Now.AddDays(3), ServicePackage = package1, Status = Model.Enums.ServiceStatus.BeingRepaired };
            var service2 = new Service { Customer = customer2, DropOffDate = DateTime.Now.AddDays(1), Mechanic = mechanic2, PickUpDate = DateTime.Now.AddDays(5), ServicePackage = package2, Status = Model.Enums.ServiceStatus.ReadyForPickUp };
            var service3 = new Service { Customer = customer3, DropOffDate = DateTime.Now.AddDays(2), Mechanic = mechanic2, PickUpDate = DateTime.Now.AddDays(3), ServicePackage = package3, Status = Model.Enums.ServiceStatus.BikeIsHere };
            context.Services.Add(service1);
            context.Services.Add(service2);
            context.Services.Add(service3);

            base.Seed(context);
        }
    }
}
