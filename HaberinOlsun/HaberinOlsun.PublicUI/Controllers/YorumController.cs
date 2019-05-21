using HaberinOlsun.BusinessLayer;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class YorumController : Controller
    {
        YorumManager yorumManager = new YorumManager();

        public ActionResult YorumYap(Yorum yorum, int Id)
        {
            yorum.HaberID = Id;
            yorumManager.Insert(yorum);

            return RedirectToAction("Detay", "Haber", new { id=Id });
        }

        public ActionResult KoseYazisi(Yorum yorum, int Id)
        {
            yorum.YaziID = Id;
            yorumManager.Insert(yorum);

            return RedirectToAction("Detay", "Yazar", new { id = Id });
        }
    }
}