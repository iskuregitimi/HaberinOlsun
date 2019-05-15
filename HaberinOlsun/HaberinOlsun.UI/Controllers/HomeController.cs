using HaberinOlsun.Entities;
using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Haberler> haberler = PostsBLL.GetPosts();
            return View(haberler);
        }
        public ActionResult Authors()
        {
            List<Yazarlar> yazarlar = PostsBLL.getAuthors();
            return View("Index");
        }

    }
}