using HaberinOlsun.Entities;
using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaberinOlsun.UI.Models;
using log4net;

namespace HaberinOlsun.UI.Controllers
{
    public class HomeController : Controller
    {
        ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ActionResult Index()
        {
            log.Info("Anasayfa Çalışıyor ve Veriler Getiriliyor");

            HomePageModel model = new HomePageModel();
            List<Yazarlar> yazarlar = PostsBLL.getAuthors();
            List<Haberler> haberler = PostsBLL.GetPosts();
            model.Haberler = haberler;
            model.Yazarlar = yazarlar;

            log.Info("Anasayfa Veri Alımı Başarılı");

            return View(model);
        }

    }
}