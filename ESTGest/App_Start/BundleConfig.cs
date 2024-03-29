﻿using System.Web;
using System.Web.Optimization;

namespace ESTGest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/custom.js",
                        "~/Scripts/myscripts.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.confirm.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            /*
                                  "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
            */

            bundles.Add(new StyleBundle("~/Content/css").Include(       
                      "~/Content/bootstrap.min.css",
                      "~/Content/custom.css",
                      "~/Content/animate.min.css",
                     "~/Content/login-form-style.css",
                      "~/Content/mycss.css"));

            /*
                     "~/Content/bootstrap.css",
                      "~/Content/site.css",
            */

            bundles.Add(new StyleBundle("~/fonts/css").Include(
                     "~/fonts/css/font-awesome.min.css"
                     ));
        }
    }
}
