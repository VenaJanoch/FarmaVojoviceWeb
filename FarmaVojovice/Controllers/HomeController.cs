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
            ViewBag.Message = "Naše farma chová kravy na volných pastvinách a tím je zaručena nejvyšší kvalita jijich masa.";
            return View();
        }

        public ActionResult Zrani()
        {
            ViewBag.Message = "Maso by mělo zrát v chladném prostředí minimálně 14 dní. Takto vystařené maso má mnohem lepší vlastnosti a chuť " +
                "při následném zpracování, než maso zpracovávané hned pro zabití.";

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

        public ActionResult _OfferTýpeFocus()
        {
            ViewBag.Message = "Naleznete u nás";

            return View();
        }


    }
}