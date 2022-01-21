using DiscountCalculatorWebAPI.Common;
using System.Web;
using System.Web.Mvc;

namespace DiscountCalculatorWebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
