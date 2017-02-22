using System.Data.Entity;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using HRM.DAL.DbContext;
using HRM.Web.DependencyInjection;
using HRM.DAL;


namespace HRM.Web
{
    public class WebTypeResolver : IWebTypeResolver
    {
        public void RegisterType(IUnityContainer container)
        {
            container.RegisterType<DbContext, HRMContext>(new InjectionConstructor());
           
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}