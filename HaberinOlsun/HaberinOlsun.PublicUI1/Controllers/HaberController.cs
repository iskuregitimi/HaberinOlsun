using HaberinOlsun.BLL;
using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI1.Controllers
{
    public class HaberController : Controller
    {
        // GET: Haber
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HaberDetay(int id)
        {
            Haberler haber = HaberBLL.haberdetay(id);

            return View(haber);
        }
    }
}