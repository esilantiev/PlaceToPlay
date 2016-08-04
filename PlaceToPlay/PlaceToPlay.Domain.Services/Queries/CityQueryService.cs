using PlaceToPlay.Domain.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceToPlay.Domain.Services.Queries
{
    public class CityQueryService : ICityQueryService
    {
        public IList<string> Get(int pageNumber, int pageSize)
        {
            var cities = new List<string> { "Chisinau", "Ialoveni", "Balti" };

            return cities;
        }
    }
}
