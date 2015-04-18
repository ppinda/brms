using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Model.Enums;

namespace BRMS.Model.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public ServiceStatus Status { get; set; }
        public DateTime DropOffDate { get; set; }
        public DateTime PickUpDate { get; set; }
    }
}
