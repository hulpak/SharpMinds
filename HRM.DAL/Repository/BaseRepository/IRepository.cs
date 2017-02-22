using HRM.DAL;
using System.Collections.Generic;

namespace HRM.DAL
{
   public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        void Edit(TEntity entity);

    }
}
