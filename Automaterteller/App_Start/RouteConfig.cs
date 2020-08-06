using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Automaterteller
{
    public class RouteConfig
    {
        // RegisterRoutes method is called when app starts
        public static void RegisterRoutes(RouteCollection routes)
        {
            // IgnoreToute as any request with .axd
            //.. will be for certain resources and system..
            //... utitlities and dealt with by seperate handler
            // *; treats last segment in url pattern as a catch all
            // meaning any sequence 
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Serial number",
                url: "serial/{letterCase}",
                defaults: new { controller = "Home", action = "Serial", letterCase = "upper" }
            );

            // Call to map route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
