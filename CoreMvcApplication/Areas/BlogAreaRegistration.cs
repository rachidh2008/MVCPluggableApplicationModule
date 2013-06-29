using System.Web.Mvc;

namespace CoreMvcApplication
{
    public class BlogAreaRegistration 
        : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "blog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "blog_default",
                "blog/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Blog.Controllers" }
            );
        }
    }
}
