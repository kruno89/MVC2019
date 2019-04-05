using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacije.Models;

namespace Validacije.Controllers
{
    public class ValidacijeController : Controller
    {
        // GET: Validacije
        // za povratak na prvi primjer promijeniti naziv u izdavanjeracuna
        // ovdje unijeti get metodu za izdavanje računa 2
        // također promijeniti kraj kod if else
        // naziv promijenjen u Metaizdavanje racuna to ispraviti i odkomentirati ono dolje
        // promijenjeno u client validaciju
        public ViewResult ClientMetaIzdavanjeRacuna()
        {
            return View(new MetaRacun() { Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString() });
        }

        public ViewResult IzdavanjeRacuna()
        {
            return View(new Racun() { Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString() });
        }

        public ViewResult IzdavanjeRacuna2()
        {
            return View(new Racun() { Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString() });
        }

        public ViewResult MetaIzdavanjeRacuna()
        {
            return View(new Racun() { Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString() });
        }

        // POST
        [HttpPost]
        public ViewResult MetaIzdavanjeRacuna(MetaRacun metaRacun, string id)
        {


            if (ModelState.IsValid)
            {
                return View("MetaRacunIzdan", metaRacun);
            }
            else
            {
                if (id == "ClientMetaIzdavanjeRacuna")
                {
                    return View("ClientMetaIzdavanjeRacuna");
                }
                return View();
            }

        }

        [HttpPost]
        public ViewResult IzdavanjeRacuna(Racun racun, string id)
        {
            //obavezne vrijednosti
            if (string.IsNullOrEmpty(racun.BrojRacuna))
            {
                ModelState.AddModelError("BrojRacuna", "Broj računa je obavezan!");
            }
            if (string.IsNullOrEmpty(racun.Zaposlenik))
            {
                ModelState.AddModelError("Zaposlenik", "Zaposlenik je obavezan!");
            }
            if (string.IsNullOrEmpty(racun.Kupac))
            {
                ModelState.AddModelError("Kupac", "Kupac je obavezan!");
            }

            //model-level validacija
            if (ModelState.IsValidField("Datum"))
            {
                if (racun.Datum < DateTime.Today.AddDays(-3))
                {
                    ModelState.AddModelError("", "Datum ne smije biti manji za više od 3 dana!");
                }
            }

            // ukupna provjera validacije
            //// ovo promijenti za povratak na prvi primjer 
            //// ovaj drugi radi i za prvi primjer sa promjenama
            if (ModelState.IsValid)
            {
                return View("RacunIzdan", racun);
            }
            else
            {
                if (id == "IzdavanjeRacuna2")
                {
                    return View("IzdavanjeRacuna2");
                }
                else
                {
                    return View();
                }
            }

        }
    }
}