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
    public class HaberController : Controller
    {
        HaberManager haberManager = new HaberManager();

        public ActionResult Detay(int id)
        {
            Haber haber = haberManager.GetHaber(id);
            haber.OkunmaSayisi += 1;
            haberManager.Update(haber);
            return View(haber);
        }
    }
}