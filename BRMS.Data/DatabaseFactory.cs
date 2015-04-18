using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRMS.Data.Interfaces;

namespace BRMS.Data
{
    public class DatabaseFactory : IDatabaseFactory
    {
        BRMSDbContext dbContext;

        public DatabaseFactory()
        {
            dbContext = new BRMSDbContext();
        }

        public BRMSDbContext Get()
        {
            return dbContext;
        }
    }
}
