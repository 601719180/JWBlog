using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JWBlog.Controllers
{
    public class HomeController : Controller
    {
        #region 首页
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region 娱乐
        public ActionResult Game()
        {
            return View();
        }
        #endregion

        #region 美食
        public ActionResult Foods()
        {
            return View();
        }
        #endregion

        #region 体育
        public ActionResult PE()
        {
            return View();
        }
        #endregion

        #region 文章详情
        public ActionResult ArticleDetails()
        {
            return View();
        }
        #endregion                                                                                                           

        #region 注册
        public ActionResult Register()
        {
            return View();
        }
        #endregion

        #region 登录
        public ActionResult Login()
        {
            return View();
        }
        #endregion


        #region 旅游
        public ActionResult Go()
        {

            return View();
        }
        #endregion

    }
}