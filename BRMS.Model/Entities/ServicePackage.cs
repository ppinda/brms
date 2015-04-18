using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        [JsonIgnore]
        public virtual ICollection<ServiceActivity> ServiceActivities { get; set; }

        [JsonIgnore]
        public virtual ICollection<Service> Services { get; set; }
    }
}
