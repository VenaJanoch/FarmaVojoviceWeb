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
            ViewBag.Message = "Naše farma chová krávy na volných pastvinách a tím je zaručena nejvyšší kvalita jejich masa.";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                "Skot je chovaný ne velkých pastvinách, které přispívají k jeho vysoké kvalitě";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Zrani()
        {
            ViewBag.Message = "Maso by mělo zrát v chladném prostředí minimálně 14 dní. Takto vystařené maso má mnohem lepší vlastnosti a chuť " +
                "při následném zpracování, než maso zpracovávané hned pro zabití.";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                "V nově zařízené bourárně je naše maso stařeno a tím získává na kvalitě";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dostihnete nás:";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                "Naleznete nás na adrese Vojovice 6 a maso si lze objednat na emailové adrese prodej@farmavojovice.cz";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                 "Fotogalerie obsahuje velké množství fotografií jak zázemí tak chovaného dobytka";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Offer()
        {
            ViewBag.Message = "U nás máte možnost zakoupit maso jak ve formě již před připravených balíčků, tak jednotlivé kusy masa samostatně." +
                "Velikost jednotlivých balíčků je pouze orientační a může se měnit. Maso lze objednat přes email nebo po telefonu";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                 "V naší nabídce naleznete veké množství kvalitního vyzrálého masa. Od masa na steaky až po maso na guláš";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult _OfferTýpeFocus()
        {
            ViewBag.Message = "Naleznete u nás";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        private string GetMeatDate()
        {
            var fileContents = System.IO.File.ReadAllText(Server.MapPath("~/Views/DateConfig.txt"));
            return fileContents.ToString();
        }

    }
}