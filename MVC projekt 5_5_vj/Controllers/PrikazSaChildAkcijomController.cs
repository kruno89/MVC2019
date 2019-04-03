﻿using MVC_projekt_5_5_vj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_projekt_5_5_vj.Controllers
{
    public class PrikazSaChildAkcijomController : Controller
    {
        // GET: PrikazSaChildAkcijom
        public ActionResult ObradiListu()
        {
            List<Artikal> artikli = new List<Artikal>()
            {
                new Artikal() { Naziv="Nogometna lopta", Cijena=250.60m, Kategorija="Sport" },
                new Artikal() { Naziv="Električna gitara", Cijena=1890, Kategorija="Glazba" },
                new Artikal() { Naziv="LED TV", Cijena=3560.99m, Kategorija="Tehnika" },
            };
            return View(artikli);
        }

        [ChildActionOnly]
        public string OdrediKategoriju(Artikal artikal)
        {
            return artikal.Kategorija;
        }
    }
}