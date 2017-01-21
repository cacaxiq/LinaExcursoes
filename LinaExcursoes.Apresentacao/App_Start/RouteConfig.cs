using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Administrativo",
                url: "Admin",
                defaults: new { controller = "Home", action = "Admin" }
            );

            routes.MapRoute(
name: "DestinosPraias",
url: "Praias",
defaults: new { controller = "Viagens", action = "Praias" }
);

            routes.MapRoute(
    name: "DestinosCidades",
    url: "Cidades",
    defaults: new { controller = "Viagens", action = "Cidades" }
);

            routes.MapRoute(
    name: "DestinosParques",
    url: "Parques",
        defaults: new { controller = "Viagens", action = "Parques" }
);

            routes.MapRoute(
    name: "DestinosEcoTurismo",
    url: "EcoTurismo",
       defaults: new { controller = "Viagens", action = "EcoTurismo" }
);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );




        }
    }
}
