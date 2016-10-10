using PlaceToPlay.Data.Infrastructure.Mappings;
using PlaceToPlay.Domain.Models.Identity;

namespace PlaceToPlay.Data.Mappings
{
    public class TokenConfiguration : EntityConfiguration<Token>
    {
        public TokenConfiguration()
        {
            Property(x => x.Expiry).IsRequired();
            HasRequired(x => x.User)
                .WithMany()
                .Map(x => x.MapKey("UsedId"))
                .WillCascadeOnDelete(false);
        }
    }
}
