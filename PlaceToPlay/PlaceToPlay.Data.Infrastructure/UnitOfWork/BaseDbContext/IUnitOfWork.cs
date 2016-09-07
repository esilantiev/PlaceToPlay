using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;

namespace PlaceToPlay.Data.Infrastructure.UnitOfWork.BaseDbContext
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
        
        DbSet<T> Set<T>() where T : Entity;
    }
}
