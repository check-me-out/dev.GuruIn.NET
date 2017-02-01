using System.Web.Optimization;

namespace Sample.Web
{
    public class BundleConfig
    {
        #region bundles

        private static readonly string[] Jquery =       {
                                                            "~/Scripts/jquery/jquery-{version}.js"
                                                        };

        private static readonly string[] JqueryVal =    {
                                                            "~/Scripts/jquery/jquery.validate*"
                                                        };

        private static readonly string[] Bootstrap =    {
                                                            "~/Scripts/bootstrap/bootstrap.js"
                                                        };

        private static readonly string[] Angular =      {
                                                            //"~/Scripts/angular/angular.js",
                                                            "~/Scripts/angular/angular-animate.js",
                                                            "~/Scripts/angular/angular-filter.js",
                                                            "~/Scripts/angular/angular-loader.js",
                                                            "~/Scripts/angular/angular-local-storage.js",
                                                            "~/Scripts/angular/angular-messages.js",
                                                            "~/Scripts/angular/angular-mocks.js",
                                                            "~/Scripts/angular/angular-resource.js",
                                                            "~/Scripts/angular/angular-route.js",
                                                            "~/Scripts/loading-bar.js"
                                                        };

        private static readonly string[] UiBootstrap =  {
                                                            "~/Scripts/bootstrap/ui/ui-bootstrap.js"
                                                        };

        private static readonly string[] UiRouter =     {
                                                            "~/Scripts/angular/ui/angular-ui-router.js",
                                                            "~/Scripts/angular/ui/angular-ui-router-tabs.js"
                                                        };

        private static readonly string[] UiSelect =     {
                                                            "~/Scripts/angular/ui/angular-ui-select.js"
                                                        };

        private static readonly string[] Misc =         {
                                                            //"~/Scripts/misc/modernizr-*",
                                                            "~/Scripts/misc/respond.js",
                                                            "~/Scripts/misc/loading-bar.js",
                                                            "~/Scripts/misc/toaster.js"
                                                        };

        #endregion

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new StyleBundle("~/Content/css/deferred-css").Include(
                        "~/Content/css/loading-bar.css",
                        "~/Content/css/toaster.css",
                        "~/Content/css/ui-select.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(Jquery));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(JqueryVal));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(Bootstrap));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(Angular));

            bundles.Add(new ScriptBundle("~/bundles/ui-bootstrap").Include(UiBootstrap));

            bundles.Add(new ScriptBundle("~/bundles/ui-router").Include(UiRouter));

            bundles.Add(new ScriptBundle("~/bundles/ui-select").Include(UiSelect));

            bundles.Add(new ScriptBundle("~/bundles/toaster").Include(Misc));

            bundles.Add(new ScriptBundle("~/bundles/third-party-libs")
                                                        //.Include(Jquery)
                                                        //.Include(Bootstrap)
                                                        .Include(Angular)
                                                        .Include(UiBootstrap)
                                                        .Include(UiRouter)
                                                        .Include(UiSelect)
                                                        .Include(Misc));
        }
    }
}
