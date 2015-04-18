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
        public Service()
        {
            Parts = new List<Part>();
        }

        public int Id { get; set; }
        public ServiceStatus Status { get; set; }
        public DateTime DropOffDate { get; set; }
        public DateTime PickUpDate { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StaffMemberId { get; set; }
        public virtual StaffMember StaffMember { get; set; }

        public int ServicePackageId { get; set; }
        public virtual ServicePackage ServicePackage { get; set; }

        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
