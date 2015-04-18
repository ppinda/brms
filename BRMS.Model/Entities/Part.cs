using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRMS.Model.Entities
{
    public class Part
    {
        public int Id { get; set; }
        public decimal Price { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }
}
