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

        //娱乐
        public ActionResult Game()
        {
            return View();
        }
    }
}