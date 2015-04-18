using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Model.Entities;
using BRMS.Data.Interfaces;

namespace BRMS.Data.Repositories
{
    public class ServicePackageRepository : DbRepository<ServicePackage>
    {
        public ServicePackageRepository(IDatabaseFactory dbContext) : base(dbContext)
        {
        }
    }
}
