using PlaceToPlay.Domain.Services.Abstract;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
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
        private readonly ICityQueryService _cityQueryService;

        public CitiesController(ICityQueryService cityQueryService)
        {
            _cityQueryService = cityQueryService;
        }

        /// <summary>
        /// Return cities by requested parameters
        /// </summary>
        /// <param name="pageNumber">Number of requested page</param>
        /// <param name="pageSize">Elements quantity on page</param>
        /// <returns></returns>
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [ResponseType(typeof(List<string>))]
        public HttpResponseMessage Get(int pageNumber=1, int pageSize = 10)
        {
            var cities = _cityQueryService.Get(pageNumber, pageSize);

            return Request.CreateResponse(HttpStatusCode.OK, cities);
        }
    }
}
