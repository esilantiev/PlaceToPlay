using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Domain.Models.Cities;

namespace PlaceToPlay.Domain.Repositories.Abstract
{
    public interface ICityRepository : IRepository<City>, IDisposable
    {
    }
}
