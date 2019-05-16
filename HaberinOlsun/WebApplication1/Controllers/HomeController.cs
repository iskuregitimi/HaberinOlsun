using Haberci.BLL;
using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Anasayfa()
        {
            //Session["Kategoriler"] = Categoriler.getkategori();

            //List<Haberler> haber = Haber.GetHaberlers();
            //return View(haber);

            AnasayfaModeller model = new AnasayfaModeller();
            List<Haberler> haber = HaberBLL.GetHaberlers();
            List<Kategori> kategori = CategorilerBLL.getkategori();
            List<Yazarlar> yazarlar = YazarBLL.yazargetir();
            model.Kategori = kategori;
            model.Haberler = haber;
            model.Yazarlar = yazarlar;

            return View(model);

        }

        public ActionResult Koseyazilari(int id)
        {
            List<KoseYazilari> koseyazisi = KoseyazisiBLL.GetKoseYazilariDetails(id);

            return View(koseyazisi);
        }
        public ActionResult HaberDetails(int id)
        {
            Haberler haber = HaberBLL.GetDetails(id);
            return View (haber);
        }

    }
}