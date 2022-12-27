using FarmaVojovice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaVojovice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Naše Farma";
            ViewBag.FirstPar = "Ekologický volný chov skotu na pastvinách nacházejících se na jižním plzeňsku.";
            ViewBag.SecondPar = "Farma Vojovice je rodinná farma, která se nachází v malebné pošumavské vesnici Vojovice," +
                " nedaleko Nepomuka, kde ji roku 1993 založil můj děda. Po navrácení vlastních pozemků začal hospodařit na 10 ha zemědělské půdy," +
                " kterou předtím obhospodařovali naši předkové. Od roku 2000 jsme se začali specializovat na chov masného skotu." +
                " V současné době máme cca 100 kusů plemene masný simentál.";
            ViewBag.ThirdPar = " Farma hospodaří v režimu ekologického zemědělství na cca 100 ha." +
                " Většinu plochy tvoří pastviny a louky. Dobytek je celoročně chován na pastvě, kde je mu umožněn volný pohyb." +
                " V zimním období jsou krmeny pouze senem a senáží z vlastní farmy. Ke zvířatům se chováme s úctou a jsme s nimi v každodenním" +
                " kontaktu.";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku nedaleko města Nepomuku." +
                " Zabývá se převážně chovem skotu a jeho prodeje." +
                " Skot je chovaný ne velkých pastvinách, které přispívají k jeho vysoké kvalitě. Prodáváme vyzrále hovězí maso";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Maturation()
        {
            ViewBag.Title = "Zrani";
            ViewBag.Message = "Nabízíme vysoce kvalitní hovězí maso z jalovic, které porážím ve věku od 20 do 28 měsíců na EKO porážce v nedalekých jatkách Blovice." +
                " Maso je ve čtvrtích následně převezeno do vlastní nově vybudované bourárny. Suché zrání masa nebo chcete-li staření probíhá tak," +
                " že se celé čtvrtě zavěsí v chladícím boxu o teplotě 0-2°C. Proces zrání trvá přibližně 14-21 dnů. Po vyzrání je maso křehké a má plně rozvinutou chuť." +
                " Námi dodávané maso se po zpracování vakuově balí (tzv. mokré zrání), čímž se zvyšuje jeho trvanlivost a do ruky se Vám dostane vyzrálé maso prvotřídní " +
                "kvality.";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Na naší farmě ve Vojovicích maso zraje v chladném prostředí minimálně 14 dní. Takto vystařené maso má mnohem lepší vlastnosti a chuť " +
                "při následném zpracování, než maso zpracovávané hned pro zabití.";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Kontakt";
            ViewBag.Message = "Dostihnete nás:";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                "Naleznete nás na adrese Vojovice 6 a maso si lze objednat na emailové adrese prodej@farmavojovice.cz";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Title = "Galerie";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                 "Fotogalerie obsahuje velké množství fotografií jak zázemí tak chovaného dobytka";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        public ActionResult Offer()
        {
            ViewBag.Title = "Naše nabídka";
            ViewBag.FirstPar = "Maso prodáváme přímo ze dvora. Můžete si jej objednat telefonicky, popř. přes email. Naše hovězí maso nabízíme jak v balíčku o hmotnosti 10kg, tak i samostatně dle ceníku. ";
            ViewBag.SecondPar = "Složení: 2 kg hovězí zadní, 2,5 kg hovězí přední, 2 kg hovězí mleté, 2,5 kg hovězí na polévku, 1 kg kostky na guláš. " +
                "Složení balíčku není pevné a může se kombinovat. Cena přibližně 2300 Kč. ";
            ViewBag.Description = "Farma Vojovice je rodinná farma nacházející se na Jižním Plzeňsku. Zabývá se převážně chovem skotu a jeho prodeje." +
                 "V naší nabídce naleznete veké množství kvalitního vyzrálého masa. Od masa na steaky až po maso na guláš";
            ViewBag.Date = GetMeatDate();
            List<OfferModel> offerList = new List<OfferModel>();
            var fileName = Server.MapPath("~/Data/OfferList.xlsx");
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream))
                {
                    var head = reader.Read();
                    while (reader.Read()) //Each row of the file
                    {
                        offerList.Add(new OfferModel
                        {
                            Name = reader.GetValue(0).ToString(),
                            Cost = reader.GetValue(1).ToString(),
                        });
                    }
                }
            }
            return View(offerList);
        }

        public ActionResult _OfferTýpeFocus()
        {
            ViewBag.Message = "Naleznete u nás";
            ViewBag.Date = GetMeatDate();
            return View();
        }

        private string GetMeatDate()
        {
            var fileContents = System.IO.File.ReadAllText(Server.MapPath("~/Data/DateConfig.txt"));
            return fileContents.ToString();
        }

    }
}