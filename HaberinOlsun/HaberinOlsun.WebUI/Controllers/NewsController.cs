using HaberinOlsun.BLL;
using HaberinOlsun.Entities;
using HaberinOlsun.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.WebUI.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewsDetail(int id)
        {
            HomePageModel model = new HomePageModel();

            //List<Haberler> haberler = HaberBLL.getHaber();
            //List<Kategori> kategoriler = KategoriBLL.GetKAtegori();
            //List<KoseYazilari> Koseyazarlar = KöseYazilariBLL.GetKöseYazilaris();
            List<Yazarlar> yazarlar = WriterBLL.getWriters();

            model.Haber = NewsBLL.getNews(id);
            NewsBLL.updateReadingNum(id);
            model.Yazarlar = yazarlar;
            //model.Yazarlar = Koseyazarlar;
            //model.Haberler = haberler;
            //model.Kategoriler = kategoriler;
            return View(model);

        }
    }
}