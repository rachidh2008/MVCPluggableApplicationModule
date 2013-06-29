using System.Web.Mvc;

namespace CoreMvcApplication
{
    public class ForumAreaRegistration 
        : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "forum";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "forum_default",
                "forum/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Forum.Controllers" }
            );
        }
    }
}
