﻿using System.Web.Mvc;

namespace Jarai.RestApi.HostingWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}