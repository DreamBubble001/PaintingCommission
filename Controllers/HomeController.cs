﻿using System;
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

    }
}