using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web;

namespace CsharpAutofacDemo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RegisterAutoFac(GlobalConfiguration.Configuration);

            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }

        void RegisterAutoFac(HttpConfiguration config)
        {
            // Setup the Container Builder
            var builder = new ContainerBuilder();

            // Register the controller in scope 
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register types
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();

            // Build the container
            var container = builder.Build();

            // Setup the dependency resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            config.DependencyResolver = new AutoFacContainer(new AutofacDependencyResolver(container));
        }
    }
}