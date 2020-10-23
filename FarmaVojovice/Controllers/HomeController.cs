using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaVojovice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Naše farma je lepší než všechny farmy na světě. Máme největšího bejka v republice a ten vám natrhne prdel raz dva";
            return View();
        }

        public ActionResult Zrani()
        {
            ViewBag.Message = "U nás zraje nejlíp.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dostihnete nás:";

            return View();
        }

        public ActionResult Gallery()
        {
           
            return View();
        }

        public ActionResult Offer()
        {
            ViewBag.Message = "Naleznete u nás";

            return View();
        }


    }
}