using HaberinOlsun.BLL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.WEBUI.Controllers
{
	public class HomeController : Controller
	{
		HaberlerBLL haberlerBLL = new HaberlerBLL();
		YazarlarBLL yazarlarBLL = new YazarlarBLL();
		KoseYazilariBLL koseyazilaribll = new KoseYazilariBLL();
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult AnaSayfa()
		{
			
			LogManager.Information("Ana Sayfa Açıldı");
			return View();
		}

		public ActionResult HaberDetay(int id)
		{
			Haberler haberdetay = haberlerBLL.HaberDetayGetir(id);
			return View(haberdetay);
		}


		//public ActionResult HaberDetay()
		//{
		//	return View();
		//}
	
		public ActionResult KoseYazıları(int id)
		{
			 Yazarlar yazar = yazarlarBLL.GetYazar(id);
			List<KoseYazilari> koseYazilaris = new List<KoseYazilari>();

			foreach (KoseYazilari item in yazar.KoseYazilaris)
			{
				koseYazilaris.Add(item);
			}
			return View(koseYazilaris);
		}
	}

}