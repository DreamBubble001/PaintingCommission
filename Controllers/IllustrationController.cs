using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaintingCommission.Controllers
{
    public class IllustrationController : Controller
    {
        // GET: Illustration
        #region 作品集
        public ActionResult Illustration()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion
    }
}