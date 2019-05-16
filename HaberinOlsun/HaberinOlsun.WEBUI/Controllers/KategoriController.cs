using HaberinOlsun.BLL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.WEBUI.Controllers
{
    public class KategoriController : Controller
    {
		KategoriBLL kategoribll = new KategoriBLL();
        // GET: Kategori
        public ActionResult Kategori(int id)
        {
			string kategori = kategoribll.HaberKategorileriGetir(id);
			List<Haberler> haberler = new List<Haberler>();
			foreach (Haberler item in kat)
			{
				haberler.Add(item);
			}
		 
            return View();
        }
    }
}