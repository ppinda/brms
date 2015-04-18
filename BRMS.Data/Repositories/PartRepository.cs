using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Model.Entities;
using BRMS.Data.Interfaces;

namespace BRMS.Data.Repositories
{
    public class PartRepository : DbRepository<Part>
    {
        public PartRepository(IDatabaseFactory dbContext) : base(dbContext)
        {
        }
    }
}
