using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShivamITsolutions
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static bool IsLogedIn { get; set; }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            IsLogedIn = false;
            ViewEngines.Engines.Add(new MobileViewEngine());

            AreaRegistration.RegisterAllAreas();

            #region Device Specific display mode
            //DisplayModes.Modes.Insert(0, new DefaultDisplayMode("safari"){

            //    ContextCondition = context => context.Request.UserAgent.ToLower().Contains("safari")
            //});

            //DisplayModes.Modes.Insert(1, new DefaultDisplayMode("ipad")
            //{
            //    ContextCondition = context => context.Request.UserAgent.ToLower().Contains("ipad")
            //});
            #endregion

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

        }
    }
}