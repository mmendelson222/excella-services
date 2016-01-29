using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //supports only one get/post etc. per class. 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ////support > 1 action per class, e.g. http://localhost:62561/api/Demo/Factors
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApiWithAction",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { action = "Get", id = RouteParameter.Optional }
            //);

            //JSON
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
