using System.Data.Entity;
using PlaceToPlay.Data.Infrastructure.UnitOfWork.BaseDbContext;
using PlaceToPlay.Data.Mappings;

namespace PlaceToPlay.Data.UnitOfWork
{
    public class PlaceToPLayDbContext : BaseDbContext
    {
        public PlaceToPLayDbContext(string nameOrConnectionString) 
            : base(nameOrConnectionString)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Configurations.Add(new CityConfiguration());
        }
    }
}
