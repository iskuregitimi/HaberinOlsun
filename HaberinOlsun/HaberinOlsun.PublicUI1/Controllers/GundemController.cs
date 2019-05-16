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
    public class GundemController : Controller
    {
        // GET: Gundem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gundem()
        {
            LogManager.Write("Gundem Oluşturuldu");
       
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