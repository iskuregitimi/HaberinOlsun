using HaberinOlsun.BLL;
using HaberinOlsun.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.WebUI.Controllers
{
    public class CornerPostController : Controller
    {
        // GET: CornerPost
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCornerPost(int id)
        {
            HomePageModel model = new HomePageModel();

            //List<Haberler> haberler = HaberBLL.getHaber();
            //List<Kategori> kategoriler = KategoriBLL.GetKAtegori();
            //List<KoseYazilari> Koseyazarlar = KöseYazilariBLL.GetKöseYazilaris();

            //model.Yazarlar = Koseyazarlar;
            //model.Haberler = haberler;
            //model.Kategoriler = kategoriler;

            int yaziId = CornerPostBLL.getCornerPosts(id).FirstOrDefault().YaziId;
            model.KoseYazisi = CornerPostBLL.getCornerPost(yaziId); 
            return View(model);
        }
    }
}