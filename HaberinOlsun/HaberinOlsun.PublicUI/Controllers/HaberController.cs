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
        // GET: Haber
        public ActionResult Index(int Id)
        {
            Haber haber = haberBLL.GetHaber(Id);
            return View(haber);
        }
    }
}