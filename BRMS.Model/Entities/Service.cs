using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Model.Enums;
using Newtonsoft.Json;

namespace BRMS.Model.Entities
{
    public class Service
    {
        public Service()
        {
            Parts = new List<Part>();
        }

        public int Id { get; set; }
        public ServiceStatus Status { get; set; }
        public DateTime DropOffDate { get; set; }
        public DateTime PickUpDate { get; set; }

        public int CustomerId { get; set; }
        [JsonIgnore]
        public virtual Customer Customer { get; set; }

        public int MechanicId { get; set; }
        [JsonIgnore]
        public virtual Mechanic Mechanic { get; set; }

        public int ServicePackageId { get; set; }
        [JsonIgnore]
        public virtual ServicePackage ServicePackage { get; set; }

        public int PaymentId { get; set; }
        [JsonIgnore]
        public virtual Payment Payment { get; set; }

        [JsonIgnore]
        public virtual ICollection<Part> Parts { get; set; }
    }
}
