﻿using HaberinOlsun.BLL;
using HaberinOlsun.Entities;
using HaberinOlsun.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.UI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryPosts(int KategoriID = 1)
        {
            List<Haberler> haber = CategoryBLL.getpostsfromcategory(KategoriID);
            return View(haber);

        }
    }
}