using System.Web.Mvc;

namespace CoreMvcApplication
{
    public class MagazineAreaRegistration 
        : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "magazine";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "magazine_default",
                "magazine/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Magazine.Controllers" }
            );
        }
    }
}
