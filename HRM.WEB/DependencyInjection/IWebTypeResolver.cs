using Microsoft.Practices.Unity;

namespace HRM.Web.DependencyInjection
{
    public interface IWebTypeResolver
    {
        void RegisterType(IUnityContainer container);
    }
}
