using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaintingCommission.Controllers
{
    public class HomeController : Controller
    {
        #region 首頁
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region 繪師簡介
        public ActionResult Profile()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        #endregion

        #region 作品集
        public ActionResult Illustration()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion

        #region 委託(+報價?)
        public ActionResult Commission()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion

        #region 排程(後端使用者顯示)
        public ActionResult Schedule()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion
    }
}