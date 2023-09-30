using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaintingCommission.Controllers
{
    public class CommissionController : Controller
    {
        // GET: Commission
        #region 委託(+報價?)
        public ActionResult Commission()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion
    }
}