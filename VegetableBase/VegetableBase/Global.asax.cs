﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using VegetableBase.Models;
using VegetableBase.Logic;

namespace VegetableBase
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Initialize the DB
            Database.SetInitializer(new ProductDatabaseInitializer());


            // Add Routes.
            RegisterCustomRoutes(RouteTable.Routes);
        }
        void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "ProductsByCategoryRoute",
                "Category/{categoryName}",
                "~/ProductList.aspx"
            );
            routes.MapPageRoute(
                "ProductByNameRoute",
                "Product/{productName}",
                "~/ProductDetails.aspx"
            );
        }
        void Application_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();

            if (exc is HttpUnhandledException)
            {
                // Pass the error on to the error page.
                Server.Transfer("ErrorPage.aspx?handler=Application_Error%20-%20Global.asax", true);
            }
        }
    }
}