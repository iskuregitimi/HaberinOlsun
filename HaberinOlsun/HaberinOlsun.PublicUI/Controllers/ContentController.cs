using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HaberIcerik(int id)
        {
            var model = AnasayfaBLL.GetNew(id);
            return View(model);
        }
        public ActionResult ContentR()
        {
            var model = AnasayfaBLL.GetNews("Gündem");
            return View(model);
        }
    }
}