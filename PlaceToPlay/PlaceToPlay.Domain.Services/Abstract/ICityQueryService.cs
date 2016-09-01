using PlaceToPlay.Domain.Services.Contracts;
using PlaceToPlay.Domain.Services.Contracts.Common;

namespace PlaceToPlay.Domain.Services.Abstract
{
    public interface ICityQueryService
    {
        PageList<CityDto> Get(int pageNumber, int pageSize);        
    }
}
