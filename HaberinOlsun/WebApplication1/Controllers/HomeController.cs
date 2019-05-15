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
            List<Haberler> haber = Haber.GetHaberlers();
            List<Kategori> kategori = Categoriler.getkategori();
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


    }
}