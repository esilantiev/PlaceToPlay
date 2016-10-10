using System;
using PlaceToPlay.Domain.Services.Abstract;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PlaceToPlay.Api.Infrastructure.Exceptions;
using PlaceToPlay.Api.Models;
using PlaceToPlay.Api.Infrastructure.Routing;

namespace PlaceToPlay.Api.Controllers
{
    /// <summary>
    /// Provides API methods to manage cities
    /// </summary>
    //[ApiVersion1RoutePrefix("cities")]
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
        [Authorize]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [ResponseType(typeof(List<string>))]
        public HttpResponseMessage Get(int pageNumber=1, int pageSize = 10)
        {
            //throw new DomainOperationException("Test domain exception");
            var cities = _cityQueryService.Get(pageNumber, pageSize);

            return Request.CreateResponse(HttpStatusCode.OK, cities);
        }

        [Route("{id:int:max(5)}")]       
        public HttpResponseMessage Get(int id)
        {          

            return Request.CreateResponse(HttpStatusCode.OK,"ID: 12312312");
        }

        [Route("{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {

            return Request.CreateResponse(HttpStatusCode.OK, "Name: test");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cityCreationModel"></param>
        /// <returns></returns>
        [Route("")]        
        public HttpResponseMessage Post(HttpRequestMessage request, CityCreationModel cityCreationModel)
        {
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
