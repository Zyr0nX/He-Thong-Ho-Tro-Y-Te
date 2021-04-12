using System.Web;
using System.Web.Mvc;

namespace He_thong_ho_tro_y_te
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
