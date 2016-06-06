using System.Collections.Generic;
using System.Data.Entity;

namespace WebApplication1.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        
        void Add(TEntity entiti);
        IEnumerable<TEntity> All();
        void Delete(TEntity entiti);
        void SaveChanges();
        void Update(TEntity entiti);
    }
}