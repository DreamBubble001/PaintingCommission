using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaintingCommission.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Illustration
        #region 插畫
        public ActionResult Illustration()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion

        #region 2DLive
        public ActionResult Live2D()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion
    }
}