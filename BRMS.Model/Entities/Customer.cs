using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRMS.Model.Entities
{
    class Customer : Person
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
