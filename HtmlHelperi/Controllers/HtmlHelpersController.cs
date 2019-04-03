using HtmlHelperi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperi.Controllers
{
    public class HtmlHelpersController : Controller
    {
        // GET: HtmlHelpers
        public ViewResult OsnovniHelperi()
        {
            return View();
        }

        // GET: PRVI ZAHTJEV POSLUŽITELJA
        private string[] mjesta = new string[] { "Split", "Osijek", "Rijeka", "Zagreb" };

        public ViewResult FormHelper()
        {
            ViewBag.Mjesta = mjesta;
            return View(new Osoba());
        }

        // POST: Zahtjev
        [HttpPost]
        public ViewResult FormHelper(Osoba osoba)
        {
            ViewBag.Mjesta = mjesta;
            ViewBag.Poruka = "Podaci uneseni!";
            return View(osoba);
        }

        //GET: REQUEST
        public ViewResult StrongTypedHelper()
        {
            ViewBag.Mjesta = mjesta;
            return View(new Osoba());
        }

        //POST: REQUEST
        [HttpPost]
        public ViewResult StrongTypedHelper(Osoba osoba)
        {
            ViewBag.Mjesta = mjesta;
            ViewBag.Poruka = "Podaci uneseni!";
            return View(osoba);
        }
    }


}