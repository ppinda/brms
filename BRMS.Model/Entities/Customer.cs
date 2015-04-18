using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRMS.Model.Entities
{
    class Customer : Person
    {
        public Customer()
        {
            Services = new List<Service>();
        }

        public virtual ICollection<Service> Services { get; set; }
    }
}
