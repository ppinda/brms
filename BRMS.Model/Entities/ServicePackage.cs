using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRMS.Model.Entities
{
    public class ServicePackage
    {
        public ServicePackage()
        {
            ServiceActivities = new HashSet<ServiceActivity>();
            Services = new List<Service>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<ServiceActivity> ServiceActivities { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
