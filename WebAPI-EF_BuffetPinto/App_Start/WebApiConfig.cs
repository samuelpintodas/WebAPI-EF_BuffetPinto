using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI_EF_BuffetPinto
{

    [RoutePrefix("api/Hotel")]
    public static class WebApiConfig
    {
        [Route("{id:int}")]
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
