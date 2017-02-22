using HRM.DAL.DbContext;
using HRM.DAL;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data.Entity;

namespace HRM.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        
        private HRMContext dbContext;

        public Repository(HRMContext db)
        {
            dbContext = db;
        }       
        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }
        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }
        public void AddRange(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().AddRange(entities);
        }
        public virtual void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().RemoveRange(entities);
        }
        public void Edit(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
