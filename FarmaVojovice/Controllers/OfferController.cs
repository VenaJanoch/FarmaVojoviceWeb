using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaVojovice.Controllers
{
    public class OfferController : Controller
    {
        public ActionResult _OfferTypeFocus()
        {
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                "Tento balíček obsahuje maso z přední části krávy";
            ViewBag.Message = "Balicek xyz - 1$";
            return View();
        }
    }
}
