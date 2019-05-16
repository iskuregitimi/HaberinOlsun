using HaberinOlsun.BLL;
using HaberinOlsun.DAL;
using HaberinOlsun.PublicUI1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            AnasayfaModel model = new AnasayfaModel();
           
            List<Haberler> haberler = HaberBLL.haber();
            List<Kategori> kategoriler = KategoriBLL.GetKAtegori();
            List<KoseYazilari> Koseyazarlar = KöseYazilariBLL.GetKöseYazilaris();

            model.KoseYazilari = Koseyazarlar;
            model.Haberler = haberler;
            model.Kategoriler = kategoriler;
            return View(model);
        }
        
    }
}