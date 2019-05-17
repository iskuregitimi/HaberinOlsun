using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaberinOlsun.BLL;
using HaberinOlsun.Entities;
using log4net;

namespace HaberinOlsun.UI.Controllers
{
    public class NewsController : Controller
    {
        ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET: News
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetPost(int id)
        {
            try
            {
                log.Info($" {id} nolu Haber Verisi Alınıyor");
                var post = PostsBLL.GetSelectedPost(id);
                return View(post);
            }catch(Exception ex)
            {
                log.Error($" Haber verisi Almada Hata=> : {ex.Message} ");
                return RedirectToAction("Index","Home");
            }

        }

        public ActionResult CornerPost(int id)
        {
            return View();
        }

    }
}