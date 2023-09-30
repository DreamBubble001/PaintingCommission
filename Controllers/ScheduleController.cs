using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaintingCommission.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        #region 排程(後端使用者顯示)
        public ActionResult Schedule()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion
    }
}