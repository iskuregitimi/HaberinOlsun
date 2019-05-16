using HaberinOlsun.Entities;
using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaberinOlsun.UI.Models;

namespace HaberinOlsun.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomePageModel model = new HomePageModel();
            List<Yazarlar> yazarlar = PostsBLL.getAuthors();
            List<Haberler> haberler = PostsBLL.GetPosts();

            model.Haberler = haberler;
            model.Yazarlar = yazarlar;
            return View(model);
        }

    }
}