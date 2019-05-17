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
    public class RSSController : Controller
    {
        // GET: RSS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult rssOkuma()
        {

            //WebRequest request = WebRequest.Create("https://www.cnnturk.com/feed/rss/bilim-teknoloji/news");
            //WebResponse response = request.GetResponse();
            //Stream rssStream = response.GetResponseStream();
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(rssStream);
            //XmlNodeList xmlnodeList = xmlDoc.SelectSingleNode("rss").SelectSingleNode("channel").SelectNodes("item");
            //List<rssModel> vievModel = new List<rssModel>();

            //for (int i = 0; i < xmlnodeList.Count; i++)
            //{
            //    rssModel model = new rssModel();

            //    model.Description = xmlnodeList.Item(i).SelectSingleNode("description").InnerText;
            //    model.Title = xmlnodeList.Item(i).SelectSingleNode("title").InnerText;
            //    model.ImageURL = xmlnodeList.Item(i).SelectSingleNode("image").InnerText;
            //    model.PubDate = xmlnodeList.Item(i).SelectSingleNode("pubDate").InnerText;
            //    model.Link = xmlnodeList.Item(i).SelectSingleNode("link").InnerText;
            //    vievModel.Add(model);

            //}

            return View();
        }
    }
}