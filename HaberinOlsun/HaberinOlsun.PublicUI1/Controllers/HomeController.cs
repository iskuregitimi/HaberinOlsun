using HaberinOlsun.BLL;
using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Haberler> haberler = HaberBLL.getHaber();
            return View(haberler);
        }
        
    }
}