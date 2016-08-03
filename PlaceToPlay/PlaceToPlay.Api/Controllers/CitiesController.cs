using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PlaceToPlay.Api.Controllers
{
    /// <summary>
    /// Provides API methods to manage cities
    /// </summary>
    [RoutePrefix("api/cities")]
    public class CitiesController : ApiController
    {
        
        public CitiesController()
        {
        }

        /// <summary>
        /// Return cities by requested parameters
        /// </summary>
        /// <param name="pageNumber">Number of requested page</param>
        /// <param name="pageSize">Elements quantity on page</param>
        /// <returns></returns>
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK)]
        //[ResponseType(typeof(PagedList<ChannelDto>))]
        public HttpResponseMessage Get(int pageNumber=1, int pageSize = 10)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
