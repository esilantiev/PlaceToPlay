using PlaceToPlay.Data.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.UnitOfWork;
using PlaceToPlay.Data.Infrastructure.UnitOfWork.BaseDbContext;
using PlaceToPlay.Domain.Repositories.Abstract;

namespace PlaceToPlay.Domain.Repositories.Implementation
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity>
        where TEntity : Entity
    {
        protected readonly BaseDbContext Context;
        public Repository(IUnitOfWorkFactory unitOfWorkFactory)
        {
            Context = unitOfWorkFactory.Create() as BaseDbContext;
        }
        public TEntity Get(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
