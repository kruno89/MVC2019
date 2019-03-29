using MVCprojekt4_2_vj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCprojekt4_2_vj.Controllers
{
    public class NarudzbaArtiklaController : Controller
    {
        // GET: NaruciArtikal
        public ViewResult NaruciArtikal()
        {
            return View(new Artikal());
        }

        // POST
        [HttpPost]
        public ViewResult NaruciArtikal(Artikal artikal)
        {
            if (artikal.Kolicina > 10)
            {
                ViewBag.Poruka = "Nema dovoljno " + artikal.Naziv + " na skladištu!";
                return View(artikal);
            }
            else
            {
                ViewBag.Poruka = "Naručeno je " +
                    artikal.Kolicina +
                    " komad/a " +
                    artikal.Naziv +
                    " sa ukupnom cijenom " +
                    artikal.Cijena * artikal.Kolicina +
                    " HRK.";
                return View(artikal);
            }
        }
    }
}