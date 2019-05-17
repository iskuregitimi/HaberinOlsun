using HaberinOlsun.BLL;
using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class HaberController : Controller
    {
        HaberBLL haberBLL = new HaberBLL();
        YorumBLL yorumBLL = new YorumBLL();
        // GET: Haber
        public ActionResult Index(int Id)
        {
            Haber haber = haberBLL.GetHaber(Id);
            haber.OkunmaSayisi += 1;
            haberBLL.Update();
            return View(haber);
        }
    }
}