using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class GundemController : Controller
    {
        // GET: Gundem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GündemPage()
        {
            var model = AnasayfaBLL.GetNews("Gündem");
            return View(model);
        }
    }
}