using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRMS.Data.Interfaces
{
    public interface IDatabaseFactory
    {
        BRMSDbContext Get();
    }
}
