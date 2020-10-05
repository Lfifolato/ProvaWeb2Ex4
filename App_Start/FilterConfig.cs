using System.Web;
using System.Web.Mvc;

namespace ProvaWeb2Ex4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
