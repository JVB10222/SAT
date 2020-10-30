using System.Web;
using System.Web.Optimization;

namespace SAT.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery.cookie.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.min.js",
                      "~/Scripts/lightbox.js",
                      "~/Scripts/front.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.css",
                      "~/Content/lightbox.css",
                      "~/Content/fontastic.css",
                      "~/Content/style.default.css",
                      "~/Content/custom.css"));
        }
    }
}


 //<!-- JavaScript files-->
 //   <script src = "vendor/jquery/jquery.min.js" ></ script >
 //   < script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
 //   <script src = "vendor/jquery.cookie/jquery.cookie.js" > </ script >
 //   < script src="vendor/lightbox2/js/lightbox.js"></script>
 //   <script src = "js/front.js" ></ script >

//<!-- Bootstrap CSS-->
//    <link rel = "stylesheet" href="vendor/bootstrap/css/bootstrap.min.css">
//    <!-- Font Awesome CSS-->
//    <link rel = "stylesheet" href="vendor/font-awesome/css/font-awesome.min.css">
//    <!-- Google fonts - Poppins-->
//    <link rel = "stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:300,400,600">
//    <!-- Lightbox-->
//    <link rel = "stylesheet" href="vendor/lightbox2/css/lightbox.css">
//    <!-- Custom font icons-->
//    <link rel = "stylesheet" href="css/fontastic.css">
//    <!-- theme stylesheet-->
//    <link rel = "stylesheet" href="css/style.default.css" id="theme-stylesheet">
//    <!-- Custom stylesheet - for your changes-->
//    <link rel = "stylesheet" href="css/custom.css">
//    <!-- Favicon-->
//    <link rel = "shortcut icon" href="img/favicon.png">
//    <!-- Tweaks for older IEs--><!--[if lt IE 9]>
//        <script src = "https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js" ></ script >
//        < script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script><![endif]-->