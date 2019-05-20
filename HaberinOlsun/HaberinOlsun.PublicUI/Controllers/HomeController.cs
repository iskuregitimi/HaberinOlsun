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
    public class HomeController : Controller
    {
        HaberBLL haberBLL = new HaberBLL();
        YazarBLL yazarBLL = new YazarBLL();
        KoseYazisiBLL koseYazisiBLL = new KoseYazisiBLL();

        public ActionResult Index()
        {
            return View();
        }    
    }
}