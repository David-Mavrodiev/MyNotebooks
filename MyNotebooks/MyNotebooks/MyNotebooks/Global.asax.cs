using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
using MyNotebooks.Services.Contracts;
using MyNotebooks.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebFormsMvp;
using WebFormsMvp.Binder;
using WebFormsMvp.Web;

namespace MyNotebooks
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}