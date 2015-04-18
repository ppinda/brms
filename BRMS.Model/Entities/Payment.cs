using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Model.Enums;

namespace BRMS.Model.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public PaymentType Type { get; set; }
    }
}
