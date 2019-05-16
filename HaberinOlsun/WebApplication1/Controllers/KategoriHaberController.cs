using Haberci.BLL;
using Haberci.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class KategoriHaberController : Controller
    {
        // GET: KategoriHaber
        public ActionResult HaberKategori(int id)
        {
            Kategori kategorii = CategorilerBLL.KategoriDetailsGetir(id);
            List<Haberler> haber = new List<Haberler>();
            foreach(Haberler item in kategorii.Haberler)
            {
                haber.Add(item);

            }


            return View(haber);
        }
    }
}