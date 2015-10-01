﻿using System.Web;
using System.Web.Optimization;

namespace lmsapi
{
    public class BundleConfig
    {
        private static string[] getAngularVirtualPaths(string ModulePath) 
        {
            return new string[] {
                "~/clientlibs/" + ModulePath + "/directives/" + "*.js",
                "~/clientlibs/" + ModulePath + "/controllers/" + "*.js",
                "~/clientlibs/" + ModulePath + "/services/" + "*.js",
                "~/clientlibs/" + ModulePath + "/filters/" + "*.js",
                "~/clientlibs/" + ModulePath + "/providers/" + "*.js"};
        }

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Scripts/botstrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/angular/angular.js",
                       "~/Scripts/angular/angular-ui-router.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            /*
             * Application Code Specific JS Files
            */
            bundles.Add(new ScriptBundle("~/bundles/app").Include(getAngularVirtualPaths("common")));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            // Application Specefic Bundle for Less Files
            var lessbundle = new Bundle("~/Content/appCss").IncludeDirectory("~/Content/Less", "*.less");
            lessbundle.Transforms.Add(new LessTransform());
            lessbundle.Transforms.Add(new CssMinify());
            bundles.Add(lessbundle);
            
        }
    }
}