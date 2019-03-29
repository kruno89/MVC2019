using Modeli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modeli.Controllers
{
    public class OsobeController : Controller
    {
        // GET: Osobe/PopuniOsobu
        public ViewResult PopuniOsobu()
        {
            return View();
        }


        // Osobe/PrikaziOsobu
        [HttpPost]
        public ViewResult PrikaziOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}