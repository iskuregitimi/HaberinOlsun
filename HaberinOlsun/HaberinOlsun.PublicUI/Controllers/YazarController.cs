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
        // GET: Yazar
        public ActionResult Index(int Id)
        {
            KoseYazilari koseyazisi = koseYazisiBLL.GetKoseYazilari(Id);
            return View(koseyazisi);
        }
    }
}