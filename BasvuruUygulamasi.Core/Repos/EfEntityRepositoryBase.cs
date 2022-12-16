using BasvuruUygulamasi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Core.Repos
{
    public class EfEntityRepositoryBase<TContext,TEntity>:IEntityRepository<TEntity>

        where TEntity : class, IEntity, new()
        where TContext : DbContext

    {
        public EfEntityRepositoryBase(TContext context)
        {
            Context= context;
        }

        protected TContext Context { get; }

        public void Add(TEntity entity)
        {
            Context.Add(entity);
            Context.SaveChanges();
        }   

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return Context.Set<TEntity>().FirstOrDefault(filter);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? Context.Set<TEntity>().ToList()
                : Context.Set<TEntity>().Where(filter).ToList();
        }
    }
}

