﻿using System.Net.Http.Headers;
using PlaceToPlay.Api.Infrastructure.Logging;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Microsoft.Owin.Security.OAuth;
using PlaceToPlay.Api.Infrastructure.Filters;

namespace PlaceToPlay.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Services.Add(typeof(IExceptionLogger), new NLogExceptionLogger());
            // Web API configuration and services

            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new DomainOperationExceptionAttribute());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            SwaggerConfig.Configure(config);

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.XmlFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/xml"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
        }
    }
}
