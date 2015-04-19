using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using BRMS.Data.Interfaces;
using BRMS.Data.Repositories;
using BRMS.Data;
using BRMS.Model.Entities;

namespace BRMS.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDatabaseFactory, DatabaseFactory>();
            container.RegisterType<IRepository<ServicePackage>, ServicePackageRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}