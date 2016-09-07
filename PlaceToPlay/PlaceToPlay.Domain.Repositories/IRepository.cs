using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;

namespace PlaceToPlay.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        TEntity Get(Guid id);

        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        


    }
}
