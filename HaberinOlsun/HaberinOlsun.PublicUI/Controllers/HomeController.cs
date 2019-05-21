using HaberinOlsun.BusinessLayer;
using HaberinOlsun.Entity;
using HaberinOlsun.PublicUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class HomeController : Controller
    {
        HaberManager haberManager = new HaberManager();
        YazarManager yazarManager = new YazarManager();

        public ActionResult Index()
        {
            IndexModel model = new IndexModel();
            List<Haber> haberler = haberManager.GetHabers();
            List<Yazarlar> yazarlar = yazarManager.GetYazars();
            model.Haberler = haberler;
            model.Yazarlar = yazarlar;
            return View(model);
        }
    }
}