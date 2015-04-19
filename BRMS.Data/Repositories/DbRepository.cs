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
        DbContext _dbContext;
        DbSet<T> _dbSet;

        public DbRepository(IDatabaseFactory dbContext)
        {
            this._dbContext = dbContext.Get();
            this._dbSet = this._dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);

            return entity;
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
