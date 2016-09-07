using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;

namespace PlaceToPlay.Data.Infrastructure.UnitOfWork.BaseDbContext
{
    public class BaseDbContext : DbContext, IUnitOfWork
    {
        public BaseDbContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public void Complete()
        {
            SaveChanges();
        }

        DbSet<T> IUnitOfWork.Set<T>()
        {
            return base.Set<T>();
        }
    }
}
