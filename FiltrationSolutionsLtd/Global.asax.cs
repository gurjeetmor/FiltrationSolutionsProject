using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FiltrationSolutionsLtd.Models;

namespace FiltrationSolutionsLtd
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<FiltrationSolutionsLtdDbContext>(new CreateDatabaseIfNotExists<FiltrationSolutionsLtdDbContext>());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
