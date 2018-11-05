using System.Web;
using System.Web.Optimization;

namespace Uprise
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
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                    "~/Scripts/js/popper.js",
                    "~/Scripts/js/stellar.js",
                    "~/Scripts/fontawesome.min.js",
                    "~/Content/vendors/lightbox/simpleLightbox.min.js",
                    "~/Content/vendors/nice-select/js/jquery.nice-select.min.js",
                    "~/Content/vendors/isotope/imagesloaded.pkgd.min.js",
                    "~/Content/vendors/isotope/isotope.pkgd.min.js",
                    "~/Content/vendors/owl-carousel/owl.carousel.min.js",
                    "~/Content/vendors/popup/jquery.magnific-popup.min.js",
                    "~/Scripts/js/jquery.ajaxchimp.min.js",
                    "~/Content/vendors/counter-up/jquery.waypoints.min.js",
                    "~/Content/vendors/counter-up/jquery.counterup.js",
                    "~/Scripts/js/mail-script.js",
                    "~/Scripts/js/theme.js",
                    "~/Scripts/aos.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/_about.css",
                      "~/Content/_courses.css",
                      "~/Content/_feature.css",
                      "~/Content/_price.css",
                      "~/Content/responsive.css",
                      "~/Content/breadcrumb.css",
                      "~/Content/style.css",
                      "~/Content/fontawesome.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/aos.css",
                      "~/Content/vendors/owl-carousel/owl.carousel.min.css",
                      "~/Content/vendors/linericon/style.css",
                      "~/Content/vendors/lightbox/simpleLightbox.css",
                      "~/Content/vendors/nice-select/css/nice-select.css",
                      "~/Content/vendors/animate-css/animate.css",
                      "~/Content/vendors/popup/magnific-popup.css"
                      ));
        }
    }
}
