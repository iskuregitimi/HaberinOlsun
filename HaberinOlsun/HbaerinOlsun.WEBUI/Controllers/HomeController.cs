using HaberinOlsun.BLL;
using HaberinOlsun.Entity;
using HaberinOlsun.WEBUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace HbaerinOlsun.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        HaberlerBLL haberlerBLL = new HaberlerBLL();
        KoseyazilariBLL koseyazilariBLL = new KoseyazilariBLL();
        YazarlarBLL yazarlarBLL = new YazarlarBLL();
        KategoriBLL kategoriBLL = new KategoriBLL();
        CommentsBLL commentsBLL = new CommentsBLL();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            //web request ile xml metnini alıyoruz.
            WebRequest request = WebRequest.Create("https://www.cnnturk.com/feed/rss/bilim-teknoloji/news");
            WebResponse response = request.GetResponse();

            //gelen xml metnini xmldocument tipine çeviriyoruz.
            Stream rssStream = response.GetResponseStream();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rssStream);

            //Haberlerin Olduğu listeyi alıyoruz.
            XmlNodeList xmlNodeList = xmlDoc.SelectSingleNode("rss").SelectSingleNode("channel").SelectNodes("item");
            List<RssHaberModel> viewModel = new List<RssHaberModel>();

            //haber xml listesinde dönerek kendi modelimizi dolduruyoruz.
            for (int i = 0; i < xmlNodeList.Count; i++)
            {
                RssHaberModel haber = new RssHaberModel();

                haber.Description = xmlNodeList.Item(i).SelectSingleNode("description").InnerText;
                haber.Title = xmlNodeList.Item(i).SelectSingleNode("title").InnerText;
                haber.pubDate = xmlNodeList.Item(i).SelectSingleNode("pubDate").InnerText;
                haber.ImageUrl = xmlNodeList.Item(i).SelectSingleNode("image").InnerText;
                haber.Link = xmlNodeList.Item(i).SelectSingleNode("link").InnerText;

                viewModel.Add(haber);
            }
            return View(viewModel);
        }
        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult HaberDetay(int id)
        {
            Haberler haberler = haberlerBLL.GetHaber(id);
            return View(haberler);
        }

        [HttpPost]
        public ActionResult HaberYorum(Comment yorum, int ID)
        {
            yorum.HaberId = ID;
            yorum.Tarih = DateTime.Now;
            commentsBLL.AddComment(yorum);
            return RedirectToAction("HaberDetay", new { id = ID });
        }

        public ActionResult KoseYazariDetay(int id)
        {
            Yazarlar yazarlar = yazarlarBLL.GetYazar(id);
            List<KoseYazilari> koseyazilari = new List<KoseYazilari>();

            foreach (KoseYazilari item in yazarlar.KoseYazilaris)
            {
                koseyazilari.Add(item);
            }
            return View(koseyazilari);
        }

        public ActionResult KategorininHaberleriDetay(int id)
        {
            Kategori kategori = kategoriBLL.GetKategori(id);
            List<Haberler> haberler = new List<Haberler>();

            foreach (HaberKategori item in kategori.HaberKategoris)
            {
                Haberler haber = haberlerBLL.GetHaber(item.HaberId);
                haberler.Add(haber);
            }
            return View(haberler);
        }

    }
}