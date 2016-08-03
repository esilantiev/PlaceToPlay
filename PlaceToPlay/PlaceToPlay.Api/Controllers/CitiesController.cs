using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceToPlay.Api.Controllers
{
    [RoutePrefix("api/cities")]
    public class CitiesController : ApiController
    {
        public CitiesController()
        {

        }

        public HttpResponseMessage Get(int pageNumber=1, int pageSize = 10)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
