using PlaceToPlay.Domain.Services.Abstract;
using System.Collections.Generic;
using PlaceToPlay.Domain.Services.Contracts;
using PlaceToPlay.Domain.Services.Contracts.Common;

namespace PlaceToPlay.Domain.Services.Queries
{
    public class CityQueryService : ICityQueryService
    {       

        public CityQueryService()
        {
            
        }
        public PageList<CityDto> Get(int pageNumber, int pageSize)
        {           
            var cities = new List<CityDto>
            {
                new CityDto { Name = "Chisinau"},
                new CityDto { Name = "Ialoveni" },
                new CityDto { Name = "Balti" },
                new CityDto { Name = "Orhei" }
            };

            var pagedList = new PageList<CityDto>
            {
                Data = cities,
                PageInfo = new PageInfo
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalCount = 10
                }
            };

            return pagedList;
        }
    }
}
