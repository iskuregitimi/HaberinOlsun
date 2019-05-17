using HaberinOlsun.BLL;
using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class YazarController : Controller
    {
        KoseYazisiBLL koseYazisiBLL = new KoseYazisiBLL();
        YazarBLL yazarbll = new YazarBLL();
        // GET: Yazar
        public ActionResult Index()
        {           
            return View();
        }
        public ActionResult Detay(int Id)
        {
            Yazar yazar = yazarbll.GetYazar(Id);
            List<KoseYazilari> koseyazilari = new List<KoseYazilari>();

            foreach (KoseYazilari item in yazar.KoseYazilari)
            {
                koseyazilari.Add(item);
            }
            return View(koseyazilari);
        }
    }
}