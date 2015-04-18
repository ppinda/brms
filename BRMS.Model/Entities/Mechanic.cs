using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRMS.Model.Entities
{
    public class Mechanic : Staff
    {
        public Mechanic()
        {
            Services = new List<Service>();
        }

        public virtual ICollection<Service> Services { get; set; }
    }
}
