using PlaceToPlay.Data.Infrastructure.Mappings;
using PlaceToPlay.Domain.Models.Cities;

namespace PlaceToPlay.Data.Mappings
{
    public class CityConfiguration : EntityConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(x => x.Name).IsRequired();            
        }
    }
}
