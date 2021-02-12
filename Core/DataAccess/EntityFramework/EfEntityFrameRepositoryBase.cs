using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityFrameRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity Entity)
        {
            //disposible
            using (TContext nortWindContext = new TContext())
            {
                var addedEntity = nortWindContext.Entry(Entity);
                addedEntity.State = EntityState.Added;
                nortWindContext.SaveChanges();
            }
        }

        public void Delete(TEntity Entity)
        {
            using (TContext nortWindContext = new TContext())
            {
                var deletedEntity = nortWindContext.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;
                nortWindContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext nortWindContext = new TContext())
            {

                return nortWindContext.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext nortWindContext = new TContext())
            {

                return filter == null ?
                nortWindContext.Set<TEntity>().ToList()
                : nortWindContext.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity Entity)
        {
            using (TContext nortWindContext = new TContext())
            {
                var updatedEntity = nortWindContext.Entry(Entity);
                updatedEntity.State = EntityState.Modified;
                nortWindContext.SaveChanges();
            }
        }
    }
}
