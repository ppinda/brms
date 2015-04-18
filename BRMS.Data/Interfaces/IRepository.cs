using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRMS.Data.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Add(T entity);

        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
