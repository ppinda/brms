using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Model.Enums;

namespace BRMS.Model.Entities
{
    public class StaffMember : Person
    {
        public StaffMember()
        {
            Services = new List<Service>();
        }

        public StaffMemeberType Type { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
