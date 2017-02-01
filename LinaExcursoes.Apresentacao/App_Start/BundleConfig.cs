using System.Web.Optimization;

namespace LinExcursoes.Apresentacao.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            string cdnHtml5shiv = "https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js";
            string cdnRespond = "https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js";
            string cdnJqueryEasy = "https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js";
            string fontsMontserrat = "https://fonts.googleapis.com/css?family=Montserrat:400,700";
            string fontsLato = "https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic";

            bundles.Add(new StyleBundle("~/bunbles/fontsMontserrat", fontsMontserrat));
            bundles.Add(new StyleBundle("~/bunbles/fontsLato", fontsLato));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/font-awesome/css/font-awesome.min.css",
                "~/Content/freelancer.min.css",
                "~/Content/jquery-ui.min.css",
                "~/Content/jquery-ui.theme.min.css",
                "~/Content/jquery-ui.structure.min.css",
                "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bunbles/cdnHTML5", cdnHtml5shiv));
            bundles.Add(new ScriptBundle("~/bunbles/CDNrespond", cdnRespond));

            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                "~/Scripts/jquery-3.1.1.min.js",
                "~/Scripts/jquery-ui-1.12.1.min.js",
                "~/Scripts/bootstrap.min.js",
                 "~/Scripts/freelancer.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/googleAnalytics").Include(
                 "~/Scripts/GoogleAnalytics.js"));

            bundles.Add(new ScriptBundle("~/bundles/cdnJqueryEasy", cdnJqueryEasy));

            bundles.Add(new ScriptBundle("~/bundles/Proprios").Include(
                "~/Scripts/Lina/*.js"));
        }
    }
}