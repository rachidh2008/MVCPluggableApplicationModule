using System.Web.Mvc;

namespace CoreMvcApplication
{
    public class VideoChannelAreaRegistration 
        : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "videoChannel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            context.MapRoute(
               "videoChannel_default",
               "videoChannel/{controller}/{action}/{id}",
               new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               new string[] { "videoChannel.Controllers" }
           );
        }
    }
}
