using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BRMS.Data.Interfaces;

namespace BRMS.Data
{
    public class DatabaseFactory : IDatabaseFactory
    {
        DbContext _dbContext;

        public DatabaseFactory()
        {
            _dbContext = new BRMSDbContext();
        }

        public DbContext Get()
        {
            return _dbContext;
        }
    }
}
