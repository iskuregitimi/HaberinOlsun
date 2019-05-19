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
		HaberlerBLL haberlerbll = new HaberlerBLL();
        // GET: Kategori
        public ActionResult Kategori(int id)
        {
			//string kategori = kategoribll.HaberKategorileriGetir(id);
			//List<Haberler> haberler = new List<Haberler>();
			//foreach (Haberler item in kat)
			//{
			//	haberler.Add(item);
			//}
		 
            return View();
        }
		public ActionResult KategoriListele(int id)
		{
			Kategori kategori = kategoribll.KategorileriGetir(id);
			List<Haberler> haber = new List<Haberler>();
			foreach ( HaberKategori item in kategori.HaberKategoris)
			{
				Haberler haberler = haberlerbll.HaberDetayGetir(item.HaberId);
			   	haber.Add(haberler);
			}
			return View(haber);

		}
		
    }
}