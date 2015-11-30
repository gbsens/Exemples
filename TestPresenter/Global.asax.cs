using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace TestPresenter
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Définition de la navigation
            MKS.Core.Presenter.Navigation.Form.Add("Index", "Default.aspx");
            MKS.Core.Presenter.Navigation.Form.Add("About", "About.aspx");

        }
    }
}