using System.Web.Optimization;

namespace HRM.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/Scripts/base/js").Include(
                        "~/Scripts/jquery-2.1.3.min.js",
                        "~/Scripts/modernizr-2.6.2.js",
                        "~/Scripts/bootstrap.min.js"));          

            bundles.Add(new ScriptBundle("~/Scripts/passwordValidation/js").Include(
                        "~/Scripts/passwordValidation.js"));

            bundles.Add(new StyleBundle("~/Content/base/css").Include(
                        "~/Content/base.css",
                        "~/Content/bootstrap.min.css",
                        "~/Content/Site.css"));
        }
    }
}