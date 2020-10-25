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
            ViewBag.Message = "Balicek xyz - 1$";
            return View();
        }
    }
}
