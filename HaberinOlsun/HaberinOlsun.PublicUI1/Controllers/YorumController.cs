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
        public ActionResult Yorumyap(YorumModel model, int id)
        {
            Comments comments = new Comments();
            comments.Gönderen = model.Comment.Gönderen;
            if (ViewBag.tipi == "Haber")
            {
                comments.HaberID = model.Comment.HaberID;
            }
            else
            {
                comments.YazıID = model.Comment.YazıID;
            }


            comments.Yorum = model.Comment.Yorum;

            YorumBLL.YorumYap(comments);


            return View();
        }
        public ActionResult yorumgetir(YorumModel model)
        {

            Comments comment = new Comments();
            comment.YazıID = model.Comment.YazıID;
            comment.HaberID = model.Comment.HaberID;
            List<Comments> com = new List<Comments>();
            com = YorumBLL.getYorum(comment);

            return View(com);
        }

    }
}