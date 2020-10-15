using System.Web;
using System.Web.Mvc;

namespace Assigment2_N01457183_BarbaraCam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
