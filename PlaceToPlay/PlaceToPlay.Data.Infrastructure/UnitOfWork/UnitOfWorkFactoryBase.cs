using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;
using PlaceToPlay.Data.Infrastructure.UnitOfWork.BaseDbContext;

namespace PlaceToPlay.Data.Infrastructure.UnitOfWork
{
    public abstract class UnitOfWorkFactoryBase<TDbContext> : IUnitOfWorkFactory
        where TDbContext : DbContext, IUnitOfWork, new()
    {
        public IUnitOfWork Create()
        {
            TDbContext dbContext = new TDbContext { };

            IObjectContextAdapter objectContextAdapter = dbContext;
            objectContextAdapter.ObjectContext.SavingChanges += ObjectContext_SavingChanges;

            return dbContext;
        }

        private void ObjectContext_SavingChanges(object sender, EventArgs e)
        {
            ObjectContext objectContext = sender as ObjectContext;

            foreach (ObjectStateEntry entry in
                ((ObjectContext)sender).ObjectStateManager.GetObjectStateEntries(EntityState.Added))
            {
                Entity entity = entry.Entity as Entity;
                if (entity == null)
                    continue;
                if (entity.Id != Guid.Empty)
                    //see http://www.entityframeworktutorial.net/EntityFramework5/attach-disconnected-entity-graph.aspx
                    throw new InvalidOperationException(
                        "Failed to insert new Entity because the Id is not empty. Usually it happens when existing entity is not attached to context.");

                entity.Id = GenerateComb();
                //AuditEntity(entity);
            }
        }

        private Guid GenerateComb()
        {
            byte[] destinationArray = Guid.NewGuid().ToByteArray();
            DateTime time = new DateTime(0x76c, 1, 1);
            DateTime now = DateTime.Now;
            TimeSpan span = new TimeSpan(now.Ticks - time.Ticks);
            TimeSpan timeOfDay = now.TimeOfDay;
            byte[] bytes = BitConverter.GetBytes(span.Days);
            byte[] array = BitConverter.GetBytes((long)(timeOfDay.TotalMilliseconds / 3.333333));
            Array.Reverse(bytes);
            Array.Reverse(array);
            Array.Copy(bytes, bytes.Length - 2, destinationArray, destinationArray.Length - 6, 2);
            Array.Copy(array, array.Length - 4, destinationArray, destinationArray.Length - 4, 4);
            return new Guid(destinationArray);
        }
    }
}
