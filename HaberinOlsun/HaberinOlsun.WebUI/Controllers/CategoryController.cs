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
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getbyCategory(int id)
        {
            HomePageModel model = new HomePageModel();

            List<Haberler> haberler = NewsBLL.getNewsbyCategory(id);
            List<Yazarlar> yazarlar = WriterBLL.getWriters();
            Kategori kategori = CategoryBLL.getCategory(id);
            model.Haberler = haberler;
            model.Yazarlar = yazarlar;
            model.Kategori = kategori;

            return View(model);
        }
    }
}