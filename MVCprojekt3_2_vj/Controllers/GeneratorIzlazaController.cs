using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCprojekt3_2_vj.Controllers
{
    public class GeneratorIzlazaController : Controller
    {
        // GET: GeneratorIzlaza
        public ActionResult PopisKosarice()
        {
            return View();
        }

        // ViewBag objekt
        public ActionResult ListaArtikala()
        {
            string[] lista = new string[] { "Skije", "Pancerice", "Sunčane naočale", "Šal", "Kapa" };
            ViewBag.Lista = lista;
            return View();
        }

        // RedirectNaMetodu
        public ActionResult RedirectNaMetodu(string id)
        {
            if (id == "Kosarica")
            {
                return RedirectToAction("PopisKosarice");
            }
            else
            {
                return RedirectToAction("ListaArtikala");
            }
        }
    }
}