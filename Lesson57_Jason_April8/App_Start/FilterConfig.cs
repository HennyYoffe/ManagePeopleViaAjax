using System.Web;
using System.Web.Mvc;

namespace Lesson57_Jason_April8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
