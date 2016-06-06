using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        public DbContext context { get; set; }
        public IDbSet<TEntity> set { get; set; }

        public GenericRepository()
            : this(new StudentSystemDbContext())
        {

        }
        public GenericRepository(DbContext data)
        {
            this.context = data;
            set = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> All()
        {
            return this.set.ToList();
        }

        public void Add(TEntity entiti)
        {
            ChangeState(entiti, EntityState.Added);
        }

        public void Delete(TEntity entiti)
        {
            ChangeState(entiti, EntityState.Deleted);
        }

        public void Update(TEntity entiti)
        {
            ChangeState(entiti, EntityState.Modified);

        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public void ChangeState(TEntity entity, EntityState state)
        {
            var dbEntry = context.Entry(entity);
            dbEntry.State = state;
        }

    }
}
