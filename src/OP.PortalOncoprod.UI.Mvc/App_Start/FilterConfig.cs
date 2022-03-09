using System.Web.Mvc;
using SimpleInjector;
using OP.PortalOncoprod.Infra.CrossCutting.MvcFilters;

namespace OP.PortalOncoprod.UI.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, Container container)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(container.GetInstance<GlobalFilterTool>());
        }
    }
}
