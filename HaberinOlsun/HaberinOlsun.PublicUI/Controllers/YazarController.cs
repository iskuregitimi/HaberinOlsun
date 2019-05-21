using HaberinOlsun.BusinessLayer;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class YazarController : Controller
    {
        YazarManager yazarManager = new YazarManager();
        KoseYazilariManager koseYazilariManager = new KoseYazilariManager();

        public ActionResult Detay(int id)
        {
            List<KoseYazilari> koseYazilari = koseYazilariManager.GetKoseYazilari(id);

            return View(koseYazilari);
        }
    }
}