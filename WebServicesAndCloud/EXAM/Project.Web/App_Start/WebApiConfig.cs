using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;

namespace BullsAndCows.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "NotificationService",
            //    routeTemplate: "api/notifications/next",
            //    defaults: new { controller = "Notifications", action = "GetNextNotification" }
            //);

            config.Routes.MapHttpRoute(
                name: "GuessService",
                routeTemplate: "api/games/{id}/guess",
                defaults: new { controller = "Guess" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Enable CORS
            //config.EnableCors(new EnableCorsAttribute("http://localhost:5000", "*", "*", "*"));
        }
    }
}
