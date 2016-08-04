using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceToPlay.Domain.Services.Abstract
{
    public interface ICityQueryService
    {
        IList<string> Get(int pageNumber, int pageSize);        
    }
}
