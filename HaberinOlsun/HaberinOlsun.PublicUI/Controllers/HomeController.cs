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

          List<Haber> habers=  haberBLL.GetHabers();
          List<Yazar> yazars = yazarBLL.GetYazars();
          List<KoseYazilari> koseyazi= koseYazisiBLL.GetKoseYazilaris();

            HaberYazarModel models = new HaberYazarModel()
            {
                Habers = habers,
                KoseYazilaris = koseyazi,
                Yazars = yazars       
            };

            return View(models);
        }    
    }
}