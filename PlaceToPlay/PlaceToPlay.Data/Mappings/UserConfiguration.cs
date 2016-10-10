using PlaceToPlay.Data.Infrastructure.Mappings;
using PlaceToPlay.Domain.Models.Identity;

namespace PlaceToPlay.Data.Mappings
{
    public class UserConfiguration : EntityConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.Email).IsRequired();
            Property(x => x.Password).IsRequired();
            HasRequired(x => x.City)
                .WithMany()
                .Map(x => x.MapKey("CityId"))
                .WillCascadeOnDelete(false);          
        }
    }
}
