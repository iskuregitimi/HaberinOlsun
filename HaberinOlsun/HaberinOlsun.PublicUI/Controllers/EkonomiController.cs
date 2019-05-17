using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class EkonomiController : Controller
    {
        // GET: Ekonomi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EkonomiPage()
        {
            var model = AnasayfaBLL.GetNews("Ekonomi");
            return View(model);
        }
    }
}