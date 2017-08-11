﻿using System.Web.Mvc;

namespace MVC_demo.Areas.ComManage
{
    public class ComManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ComManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ComManage_default",
                "ComManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] {"MVC_demo.Areas.ComManage.Controllers"}
            );
        }
    }
}