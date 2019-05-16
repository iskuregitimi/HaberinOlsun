using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HaberinOlsun.WEBUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

			LogManager.Information("bismillah");

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
