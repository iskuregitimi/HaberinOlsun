using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaberinOlsun.BLL;
using HaberinOlsun.Entities;

namespace HaberinOlsun.UI.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetPost(int id)
        {
            var post = PostsBLL.GetSelectedPost(id);
            return View(post);
        }

        public ActionResult CornerPost(int id)
        {
            return View();
        }

    }
}