using HaberinOlsun.BLL;
using HaberinOlsun.ENTITY;
using HaberinOlsun.PublicUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class YorumController : Controller
    {
        YorumBLL yorumBLL = new YorumBLL();
        HaberBLL haberBLL = new HaberBLL();


        [HttpPost]
        public ActionResult HaberYorum(int Id, Yorum yorum)
        {
            yorum.Tarih = DateTime.Now;
            yorum.HaberId = Id;
            yorumBLL.Add(yorum);
            return RedirectToAction("Index", "Haber", new { id = Id });
        }

        [HttpPost]
        public ActionResult YaziYorum(int Id, Yorum yorum)
        {
            yorum.Tarih = DateTime.Now;
            yorum.YaziId = Id;
            yorumBLL.Add(yorum);
            return RedirectToAction("Detay", "Yazar", new { id = Id });
        }
    }
}