using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace DependencyInjectionPrototype.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            IIocBootstrapper bootstrapper = new UnityBootstrapper();
            IInjectionContainer container = bootstrapper.GetContainer();
            DependencyResolver.SetResolver(new IocDependencyResolver(container));
        }
    }
}
