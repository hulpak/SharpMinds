using System.Linq;
using Microsoft.Practices.Unity.InterceptionExtension;
using Microsoft.Practices.Unity;
using HRM.Web.DependencyInjection;

namespace HRM.Web.DependencyInjection
{
    public static class DependencyResolverConfig
    {
        private static IUnityContainer _container;
        public static IUnityContainer Container
        {
            get
            {
                return _container;
            }
        }

        public static void RegisterType(params IWebTypeResolver[] typeResolvers)
        {
            _container = BuildUnityContainer(typeResolvers);
        }

        public static IUnityContainer BuildUnityContainer(params IWebTypeResolver[] typeResolvers)
        {
            var container = new UnityContainer();
            container.AddNewExtension<Interception>();
            if (typeResolvers != null && typeResolvers.Any())
            {
                foreach (var typeResolver in typeResolvers)
                {
                    typeResolver.RegisterType(container);
                }
            }
            return container;
        }
    }
}