using Microsoft.Practices.Unity;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using System.Web.Http;
using Unity.WebApi;

namespace PlaceToPlay.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();           

            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToArray();

            container.RegisterTypes(
                AllClasses.FromAssemblies(assemblies),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.Transient);            

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}