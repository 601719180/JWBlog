using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JWBlog.Controllers
{
    public class HomeController : Controller
    {
        //首页
        public ActionResult Index()
        {
            return View();
        }

        //注册
        public ActionResult Register()
        {
            return View();
        }

        //登录
        public ActionResult Login()
        {
            return View();
        }

    }
}