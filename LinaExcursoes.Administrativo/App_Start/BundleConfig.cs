using System.Web;
using System.Web.Optimization;

namespace LinaExcursoes.Administrativo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JS/core").Include(
                        "~/assets/global/plugins/jquery.min.js",
                        "~/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                        "~/assets/global/plugins/js.cookie.min.js",
                        "~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/assets/global/plugins/jquery.blockui.min.js",
                        "~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js"));

            bundles.Add(new ScriptBundle("~/JS/global/plugins").Include(
                        "~/assets/global/scripts/app.min.js"));

            bundles.Add(new ScriptBundle("~/JS/plugins").Include(
                        "~/assets/global/plugins/moment.min.js",
                        "~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.js",
                        "~/assets/global/plugins/morris/morris.min.js",
                        "~/assets/global/plugins/morris/raphael-min.js",
                        "~/assets/global/plugins/counterup/jquery.waypoints.min.js",
                        "~/assets/global/plugins/counterup/jquery.counterup.min.js",
                        "~/assets/global/plugins/amcharts/amcharts/amcharts.js",
                        "~/assets/global/plugins/amcharts/amcharts/serial.js",
                        "~/assets/global/plugins/amcharts/amcharts/pie.js",
                        "~/assets/global/plugins/amcharts/amcharts/radar.js",
                        "~/assets/global/plugins/amcharts/amcharts/themes/light.js",
                        "~/assets/global/plugins/amcharts/amcharts/themes/patterns.js",
                        "~/assets/global/plugins/amcharts/amcharts/themes/chalk.js",
                        "~/assets/global/plugins/amcharts/ammap/ammap.js",
                        "~/assets/global/plugins/amcharts/ammap/maps/js/worldLow.js",
                        "~/assets/global/plugins/amcharts/amstockcharts/amstock.js",
                        "~/assets/global/plugins/fullcalendar/fullcalendar.min.js",
                        "~/assets/global/plugins/horizontal-timeline/horizontal-timeline.js",
                        "~/assets/global/plugins/flot/jquery.flot.min.js",
                        "~/assets/global/plugins/flot/jquery.flot.resize.min.js",
                        "~/assets/global/plugins/flot/jquery.flot.categories.min.js",
                        "~/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js",
                        "~/assets/global/plugins/jquery.sparkline.min.js",
                        "~/assets/global/plugins/jqvmap/jqvmap/jquery.vmap.js",
                        "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.russia.js",
                        "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.world.js",
                        "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.europe.js",
                        "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.germany.js",
                        "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.usa.js",
                        "~/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js",
                        "~/assets/pages/scripts/dashboard.min.js",
                        "~/assets/layouts/layout/scripts/layout.min.js",
                        "~/assets/layouts/layout/scripts/demo.min.js",
                        "~/assets/layouts/global/scripts/quick-sidebar.min.js",
                        "~/assets/layouts/global/scripts/quick-nav.min.js"));

            bundles.Add(new ScriptBundle("~/JS/loginjs").Include(
                        "~/assets/global/plugins/jquery-validation/js/jquery.validate.min.js",
                        "~/assets/global/plugins/jquery-validation/js/additional-methods.min.js",
                        "~/assets/global/plugins/select2/js/select2.full.min.js",
                        "~/assets/pages/scripts/login.min.js"));

            bundles.Add(new StyleBundle("~/CSS/core").Include(
                        "~/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                        "~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                        "~/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                        "~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css"));

            bundles.Add(new StyleBundle("~/CSS/global").Include(
                        "~/assets/global/css/components.min.css",
                        "~/assets/global/css/plugins.min.css"));

            bundles.Add(new StyleBundle("~/CSS/logincss").Include(
                        "~/assets/global/plugins/select2/css/select2.min.css",
                        "~/assets/global/plugins/select2/css/select2-bootstrap.min.css", 
                        "~/assets/pages/css/login.min.css"));
        }
    }
}

////BEGIN PAGE LEVEL PLUGINS
//"~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.css",
//"~/assets/global/plugins/morris/morris.css",
//"~/assets/global/plugins/fullcalendar/fullcalendar.min.css",
//"~/assets/global/plugins/jqvmap/jqvmap/jqvmap.css",
////BEGIN THEME LAYOUT STYLES
//"~/assets/layouts/layout/css/layout.min.css",
//"~/assets/layouts/layout/css/themes/darkblue.min.css",
//"~/assets/layouts/layout/css/custom.min.css"));