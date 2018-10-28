using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using TeamLindsay.Api.Controllers;
using TeamLindsay.Api.Installer;

namespace TeamLindsay.Api
{
    public class WebApiApplication : HttpApplication, IContainerAccessor
    {
        public IWindsorContainer Container { get; private set; }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DependencyInjection();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "*");
                HttpContext.Current.Response.End();
            }
        }

        public void DependencyInjection()
        {
            Container = new WindsorContainer();
            Container.Kernel.Resolver.AddSubResolver(new CollectionResolver(Container.Kernel, true));

            var installCollections = new List<IWindsorInstaller>
            {
                new MealPlanner.Data.Installer.RepositoryInstaller(),
                new MealPlanner.Service.Installer.ServiceInstaller()                
            };

            Container.AddFacility<TypedFactoryFacility>()
                .Install(installCollections.ToArray());

            Container.Register(Classes.FromThisAssembly()
                .BasedOn<IHttpController>()
                .LifestyleTransient()
                .Configure(c => c.LifeStyle.Transient.LifestyleTransient()));

            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WebApiControllerFactory(Container));
            GlobalConfiguration.Configuration.DependencyResolver = new WindsorDependencyResolver(Container.Kernel);
        }
    }
}
