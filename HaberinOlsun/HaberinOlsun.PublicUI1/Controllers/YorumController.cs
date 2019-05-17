using HaberinOlsun.BLL;
using HaberinOlsun.DAL;
using HaberinOlsun.PublicUI1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI1.Controllers
{
    public class YorumController : Controller
    {
        // GET: Yorum
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yorumyap(YorumModel model)
        {
            Comments comments = new Comments();
            comments.Gönderen = model.Gönderen;
            comments.HaberID = model.HaberID;
            comments.YazıID = model.YazıID;
            comments.Yorum = model.Yorum;

            YorumBLL.YorumYap(comments);


            return View();
        }
        public ActionResult yorumgetir(YorumModel model)
        {

            Comments comment = new Comments();
            comment.YazıID = model.YazıID;
            comment.HaberID = model.HaberID;
           List< Comments> com = new List<Comments>();
           com= YorumBLL.getYorum(comment);

            return View(com);
        }

    }
}