using Pogledi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pogledi.Controllers
{
    public class ParcijalniPoglediController : Controller
    {
        
        public ViewResult PrikaziKosaricu()
        {
            List<Artikl> lArtikl = new List<Artikl>()
            {
                new Artikl () { Naziv="Kruh", Cijena=8.9m, Kolicina=3 },
                new Artikl () { Naziv="Sir", Cijena=54.7m, Kolicina=1 },
                new Artikl () { Naziv="Mlijeko", Cijena=6.5m, Kolicina=1 }
            };
            return View(lArtikl);
        }
    }
}