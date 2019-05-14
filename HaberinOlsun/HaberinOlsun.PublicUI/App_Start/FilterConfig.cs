using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
