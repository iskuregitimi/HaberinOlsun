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
    public class TrController : Controller
    {
        // GET: Tr
        public ActionResult Anasayfa()
        {
            HomePageModel model = new HomePageModel();

            List<Haberler> haberler = NewsBLL.getCurrentNews();
            List<Yazarlar> yazarlar = WriterBLL.getWriters();
            List<Gundem> gundemler = CurrentBLL.getCurrents();

            model.Haberler = haberler;
            model.Yazarlar = yazarlar;
            model.Gundemler = gundemler;

            return View(model);
        }
    }
}