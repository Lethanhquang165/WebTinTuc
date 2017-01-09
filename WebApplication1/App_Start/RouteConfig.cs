using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AdminHomePage",
                url: "{controller}-page.aspx",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LogIn",
                url: "log-in.aspx",
                defaults: new { controller = "Admin", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "LogOut",
                url: "log-out.aspx",
                defaults: new { controller = "Admin", action = "Logout", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "TheLoai",
                url: "the-loai/{id}_{metatitle}",
                defaults: new { controller = "TinTuc", action = "Tintheotheloai", id = UrlParameter.Optional, metatitle = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ChiTiet",
                url: "tin-tuc/{id}",
                defaults: new { controller = "TinTuc", action = "Chitiettin", id = UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "TrangChu",
                url: "home.aspx",
                defaults: new { controller = "TinTuc", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TinTuc", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
