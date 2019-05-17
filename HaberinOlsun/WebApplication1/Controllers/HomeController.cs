using Haberci.BLL;
using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Anasayfa()
        {
            //Session["Kategoriler"] = Categoriler.getkategori();

            //List<Haberler> haber = Haber.GetHaberlers();
            //return View(haber);

            AnasayfaModeller model = new AnasayfaModeller();
            List<Haberler> haber = HaberBLL.GetHaberlers();
            List<Kategori> kategori = CategorilerBLL.getkategori();
            List<Yazarlar> yazarlar = YazarBLL.yazargetir();
            model.Kategori = kategori;
            model.Haberler = haber;
            model.Yazarlar = yazarlar;

            WebRequest request = WebRequest.Create("https://www.cnnturk.com/feed/rss/yasam/news");
            WebResponse response = request.GetResponse();

            Stream rssStream = response.GetResponseStream();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rssStream);
            List<RssHaberModel> viewModel = new List<RssHaberModel>();

            XmlNodeList xmlNodeList = xmlDoc.SelectSingleNode("rss").SelectSingleNode("channel").SelectNodes("item");
            for(int i=0; i<xmlNodeList.Count; i++)
            {
                RssHaberModel haberler = new RssHaberModel();
                haberler.Description = xmlNodeList.Item(i).SelectSingleNode("description").InnerText;
                haberler.Title = xmlNodeList.Item(i).SelectSingleNode("title").InnerText;
                haberler.ImageUrl = xmlNodeList.Item(i).SelectSingleNode("image").InnerText;
                haberler.pubDate = xmlNodeList.Item(i).SelectSingleNode("pubDate").InnerText;
                haberler.Link = xmlNodeList.Item(i).SelectSingleNode("link").InnerText;
                viewModel.Add(haberler);
              
                
            }
            model.RssHaber = viewModel;

            return View(model);

        }

        public ActionResult Koseyazilari(int id)
        {
            LogManager.Write("Şuanda köşe yazılarına girildi");
            List<KoseYazilari> koseyazisi = KoseyazisiBLL.GetKoseYazilariDetails(id);

            return View(koseyazisi);
        }
        public ActionResult HaberDetails(int id)
        {
            Haberler haber = HaberBLL.GetDetails(id);            
            haber.OkunmaSayisi += 1;
            HaberBLL.HaberlerIdArtması(haber);
                
          

            return View (haber);
        }
        //public ActionResult About()
        //{
        //    //WebRequest request = WebRequest.Create("https://www.cnnturk.com/feed/rss/bilim-teknoloji/news");
        //    //WebResponse response = request.GetResponse();

        //    //Stream rssStream = response.GetResponseStream();
        //    //XmlDocument xmlDoc = new XmlDocument();
        //    //xmlDoc.Load(rssStream);

        //    //XmlNodeList xmlNodeList = xmlDoc.SelectSingleNode("rss").SelectSingleNode("channel").SelectNodes("item");

        //    //List<RssHaberModel> viewModel = new List<RssHaberModel>();

        //    //for(int i=0; i<xmlNodeList.Count; i++)
        //    //{
        //    //    RssHaberModel haber = new RssHaberModel();
        //    //    haber.Description = xmlNodeList.Item(i).SelectSingleNode("description").InnerText;
        //    //    haber.Title = xmlNodeList.Item(i).SelectSingleNode("title").InnerText;
        //    //    haber.ImageUrl = xmlNodeList.Item(i).SelectSingleNode("image").InnerText;
        //    //    haber.pubDate = xmlNodeList.Item(i).SelectSingleNode("pubDate").InnerText;
        //    //    haber.Link = xmlNodeList.Item(i).SelectSingleNode("link").InnerText;
        //    //    viewModel.Add(haber);


        //    //}

        //    //return View(viewModel);





        //}

    }
}