using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using PlaceToPlay.Api.Infrastructure.Exceptions;

namespace PlaceToPlay.Api.Infrastructure.Filters
{
    /// <summary>
    /// Hadles <see cref="DomainOperationException"/>s by returning HTTP Status code equals to 400 and the exception message.
    /// </summary>
    public class DomainOperationExceptionAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// Raises the exception event.
        /// </summary>
        /// <param name="context">The context for the action.</param>
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is DomainOperationException)
            {
                context.Response = context.ActionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, context.Exception.Message);
            }
        }
    }
}
