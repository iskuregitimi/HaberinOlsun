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
    public class HaberController : Controller
    {
        // GET: Haber
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HaberDetay(int id)
        {
            
            AnasayfaModel model = new AnasayfaModel();
            
            model.haber = HaberBLL.haberdetay(id);
            List<Haberler> haberler = HaberBLL.haber();
            List<Kategori> kategoriler = KategoriBLL.GetKAtegori();
            List<KoseYazilari> Koseyazarlar = KöseYazilariBLL.GetKöseYazilaris();
            
            model.haber.OkunmaSayisi += 1;
            model.KoseYazilari = Koseyazarlar;
            model.Haberler = haberler;
            model.Kategoriler = kategoriler;
            return View(model);
        }
    }
}