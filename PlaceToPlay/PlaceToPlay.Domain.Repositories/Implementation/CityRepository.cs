using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.UnitOfWork;
using PlaceToPlay.Domain.Models.Cities;
using PlaceToPlay.Domain.Repositories.Abstract;

namespace PlaceToPlay.Domain.Repositories.Implementation
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
            
        }
        
    }
}
