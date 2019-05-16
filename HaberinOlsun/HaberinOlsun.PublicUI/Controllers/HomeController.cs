using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HaberGetir()
        {
            var model = AnasayfaBLL.GetNews("All");
            return View(model);
        }

        public ActionResult EkonomiGetir()
        {
            var model = AnasayfaBLL.GetNews("Ekonomi");
            return View(model);
        }

        public ActionResult GündemGetir()
        {
            var model = AnasayfaBLL.GetNews("Gündem");
            return View(model);
        }
        public ActionResult AllNews()
        {
            var model = AnasayfaBLL.GetNews("Hepsi");
            return View(model);
        }
        public ActionResult YazarGetir()
        {
            var model = AnasayfaBLL.GetYazar();
            return View(model);
        }
    }
}