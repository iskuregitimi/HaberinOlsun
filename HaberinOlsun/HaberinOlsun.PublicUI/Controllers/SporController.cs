using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class SporController : Controller
    {
        // GET: Spor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SporPage()
        {
            var model = AnasayfaBLL.GetNews("Spor");
            return View(model);
        }
    }
}