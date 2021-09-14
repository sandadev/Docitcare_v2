using System.Web;
using System.Web.Optimization;

namespace Docitcare_v2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/Theme").Include(
                     "~/Content/Theme/assets/js/jquery.min.js",
                     "~/Content/Theme/assets/js/jquery.slimscroll.js",
                     "~/Content/Theme/assets/js/app-chat.js",
                     "~/Content/Theme/assets/js/app.js",
                     "~/Content/Theme/assets/js/bootstrap-inputmask.min.js",
                     "~/Content/Theme/assets/js/bootstrap.bundle.min.js",
                     "~/Content/Theme/assets/js/calender.js",
                     "~/Content/Theme/assets/js/Chart.min.js",
                     "~/Content/Theme/assets/js/index.bundle.js",
                     "~/Content/Theme/assets/js/metismenu.min.js",
                     "~/Content/Theme/assets/js/waves.min.js",
                      "~/Content/Theme/assets/js/tag-inputs.js",
                     "~/Scripts/moment.js",
                     "~/Scripts/bootstrap-datetimepicker.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/Docitcare").Include(
                "~/DocitScripts/Entity.js",
                "~/DocitScripts/Login.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Theme/css").Include(
                      "~/Content/Theme/assets/css/bootstrap.min.css",
                      "~/Content/Theme/assets/css/app-chat.css",
                      "~/Content/Theme/assets/css/calender.css",
                      "~/Content/Theme/assets/css/chart-examples.css",
                      "~/Content/Theme/assets/css/icons.css",
                      "~/Content/Theme/assets/css/input-material.css",
                      "~/Content/Theme/assets/css/metismenu.min.css",
                      "~/Content/Theme/assets/css/palette-gradient.css",
                      "~/Content/Theme/assets/css/style.css",
                      "~/Content/bootstrap-datetimepicker.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css"
                      ));
        }
    }
}
