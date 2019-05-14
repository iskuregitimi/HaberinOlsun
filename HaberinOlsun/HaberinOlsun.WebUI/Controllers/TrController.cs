using HaberinOlsun.BLL;
using HaberinOlsun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.WebUI.Controllers
{
    public class TrController : Controller
    {
        // GET: Tr
        public ActionResult Anasayfa()
        {
            Haberler haber = NewsBLL.getNews();
            return View(haber);
        }
    }
}