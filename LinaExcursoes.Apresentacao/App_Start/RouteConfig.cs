using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LinaExcursoes.Apresentacao.App_Start
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
                name: "DetalheViagens",
                url: "Detalhe/{id}",
                defaults: new { controller = "Viagens", action = "Detalhe", id = "id" }
            );

            routes.MapRoute(
                name: "LeadPage",
                url: "Promocoes/{id}",
                defaults: new { controller = "Lead", action = "Promocoes", id = "id" }
            );

            routes.MapRoute(
                name: "PaginaInicial",
                url: "Home",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );




        }
    }
}
