using System.Data.Entity.ModelConfiguration;
using PlaceToPlay.Data.Infrastructure.Abstract;

namespace PlaceToPlay.Data.Infrastructure.Mappings
{
    public abstract class EntityConfiguration<TEntity> : EntityTypeConfiguration<TEntity> 
        where TEntity : Entity 
    {
        public EntityConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
