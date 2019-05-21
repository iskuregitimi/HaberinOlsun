using HaberinOlsun.BusinessLayer;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class KategoriController : Controller
    {
        HaberManager haberManager = new HaberManager();

        public ActionResult Haber(int id)
        {
            IQueryable<HaberKateModel> haber = haberManager.KateHaber(id);

            return View(haber);
        }
    }
}