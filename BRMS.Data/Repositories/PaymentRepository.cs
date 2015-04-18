using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Model.Entities;
using BRMS.Data.Interfaces;

namespace BRMS.Data.Repositories
{
    public class PaymentRepository : DbRepository<Payment>
    {
        public PaymentRepository(IDatabaseFactory dbContext) : base(dbContext)
        {
        }
    }
}
