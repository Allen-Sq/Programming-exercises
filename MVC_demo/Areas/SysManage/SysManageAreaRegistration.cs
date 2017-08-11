using System.Web.Mvc;

namespace MVC_demo.Areas.SysManage
{
    public class SysManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SysManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SysManage_default",
                "SysManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "MVC_demo.Areas.SysManage.Controllers" }

            );
        }
    }
}