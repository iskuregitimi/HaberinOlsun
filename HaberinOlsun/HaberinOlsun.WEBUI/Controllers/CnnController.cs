using HaberinOlsun.WEBUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace HaberinOlsun.WEBUI.Controllers
{
	public class CnnController : Controller
	{
		// GET: Cnn
		public ActionResult Index()
		{
			WebRequest request = WebRequest.Create("https://www.cnnturk.com/feed/rss/dunya/news");
			WebResponse response = request.GetResponse();


			Stream rssstream = response.GetResponseStream();
			XmlDocument XmlDoc = new XmlDocument();
			XmlDoc.Load(rssstream);

			XmlNodeList xmlnodelist = XmlDoc.SelectSingleNode("rss").SelectSingleNode("channel").SelectNodes("item");
			List<RssModel> viewModel = new List<RssModel>();

			for (int i = 0; i < xmlnodelist.Count; i++)
			{
				RssModel model = new RssModel();
				model.Description = xmlnodelist.Item(i).SelectSingleNode("description").InnerText;
				model.ImageURL = xmlnodelist.Item(i).SelectSingleNode("image").InnerText;
				model.Title = xmlnodelist.Item(i).SelectSingleNode("title").InnerText;
				model.pubDate = xmlnodelist.Item(i).SelectSingleNode("pubDate").InnerText;
				model.Link = xmlnodelist.Item(i).SelectSingleNode("link").InnerText;
				viewModel.Add(model);
			}
				return View(viewModel);


		}






	}
}