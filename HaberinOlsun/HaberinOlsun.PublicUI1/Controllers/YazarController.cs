using HaberinOlsun.BLL;
using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI1.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yazar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getKoseYazıDetay(int id)
        {
            KoseYazilari koseYazilari = KöseYazilariBLL.detaykoseYazilari(id);

            return View(koseYazilari);
        }
    }
}