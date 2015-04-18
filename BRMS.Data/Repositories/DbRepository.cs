using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BRMS.Data.Interfaces;

namespace BRMS.Data.Repositories
{
    public class DbRepository<T> : IRepository<T> where T: class
    {
        DbContext dbContext;
        DbSet<T> dbSet;

        public DbRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T Add(T entity)
        {
            dbSet.Add(entity);

            return entity;
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
    }
}
