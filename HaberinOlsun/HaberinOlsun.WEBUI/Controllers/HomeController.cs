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
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult AnaSayfa()
		{
			return View();
		}

		//public ActionResult HaberDetay(int id)
		//{
		//	Haberler haberdetay = haberlerBLL.HaberDetayGetir(id);
		//	return View(haberdetay);
		//}


		public ActionResult HaberDetay()
		{
			return View();
		}
	}

}