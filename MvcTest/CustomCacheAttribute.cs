using System.Web.Mvc;

namespace MvcTest
{
    public class CustomCacheAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Cache.SetMaxAge(new System.TimeSpan(5, 5, 5));
            filterContext.HttpContext.Response.Cache.SetCacheability(System.Web.HttpCacheability.Public);
        }
    }
}