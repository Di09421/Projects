using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapMvcAttributeRoutes();

           // routes.MapRoute(
           //    name: "SelfRoute",
           //    url: "Demo",
           //    defaults: new { controller = "Default", action = "Index", }
           //);
           // routes.MapRoute(
           //    name: "Second",
           //    url: "{controller}/{id}",
           //    defaults: new { controller = "About", action = "About", }
           //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
