using HaberinOlsun.BLL;
using HaberinOlsun.DAL;
using HaberinOlsun.PublicUI1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace HaberinOlsun.PublicUI1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            LogManager.Write("Euzübillahimineşşeytanirracim");
            AnasayfaModel model = new AnasayfaModel();
           
            List<Haberler> haberler = HaberBLL.haber();
            List<Kategori> kategoriler = KategoriBLL.GetKAtegori();
            List<KoseYazilari> Koseyazarlar = KöseYazilariBLL.GetKöseYazilaris();

            model.KoseYazilari = Koseyazarlar;
            model.Haberler = haberler;
            model.Kategoriler = kategoriler;



            WebRequest request = WebRequest.Create("https://www.cnnturk.com/feed/rss/bilim-teknoloji/news");
            WebResponse response = request.GetResponse();
            Stream rssStream = response.GetResponseStream();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rssStream);
            XmlNodeList xmlnodeList = xmlDoc.SelectSingleNode("rss").SelectSingleNode("channel").SelectNodes("item");
            List<rssModel> vievModel = new List<rssModel>();

            for (int i = 0; i < xmlnodeList.Count; i++)
            {
                rssModel rssmodel = new rssModel();

                rssmodel.Description = xmlnodeList.Item(i).SelectSingleNode("description").InnerText;
                rssmodel.Title = xmlnodeList.Item(i).SelectSingleNode("title").InnerText;
                rssmodel.ImageURL = xmlnodeList.Item(i).SelectSingleNode("image").InnerText;
                rssmodel.PubDate = xmlnodeList.Item(i).SelectSingleNode("pubDate").InnerText;
                rssmodel.Link = xmlnodeList.Item(i).SelectSingleNode("link").InnerText;
                vievModel.Add(rssmodel);

            }
            model.rssmodel = vievModel;
            return View(model);
        }
        
    }
}