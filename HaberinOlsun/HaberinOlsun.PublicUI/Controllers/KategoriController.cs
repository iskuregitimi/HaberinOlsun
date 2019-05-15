using HaberinOlsun.BLL;
using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class KategoriController : Controller
    {
        KategoriBLL kategoribll = new KategoriBLL();
        // GET: Kategori
        public ActionResult Kategori(int Id)
        {
            Kategori kategori = kategoribll.GetKategori(Id);
            List<Haber> haberler = new List<Haber>();
            foreach (Haber item in kategori.Haber)
            {
                haberler.Add(item);
            }
            return View(haberler);
        }
    }
}