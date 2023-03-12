using System.Web;
using System.Web.Mvc;

namespace VuongQuangTung_2080600795_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
