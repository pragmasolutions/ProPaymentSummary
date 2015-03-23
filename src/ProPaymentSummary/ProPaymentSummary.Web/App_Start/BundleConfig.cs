using System.Web;
using System.Web.Optimization;

namespace ProPaymentSummary.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                .Include("~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryplugins")
                .Include("~/Scripts/jquery-plugins/jquery.isotope.min.js")
                .Include("~/Scripts/jquery-plugins/jquery.prettyPhoto.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js",
                         "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/css/bootstrap.min.css")
                .Include("~/Content/css/font-awesome.min.css")
                .Include("~/Content/css/prettyPhoto.css")
                .Include("~/Content/css/Site.css")
                .Include("~/Content/css/main.css"));
        }
    }
}
