using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaintingCommission.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        #region 繪師簡介
        public ActionResult Profile()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        #endregion
    }
}