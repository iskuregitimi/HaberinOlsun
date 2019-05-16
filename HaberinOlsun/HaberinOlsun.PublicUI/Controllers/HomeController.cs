using HaberinOlsun.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberinOlsun.PublicUI.Controllers
{
    public class HomeController : Controller
    {
        HaberManager haberler = new HaberManager();
        // GET: Home
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult Kat(int id)
        {
            return View();
        }
       
    }
}