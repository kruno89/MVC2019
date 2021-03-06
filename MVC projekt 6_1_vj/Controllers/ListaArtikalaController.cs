﻿using MVC_projekt_6_1_vj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_projekt_6_1_vj.Controllers
{
    public class ListaArtikalaController : Controller
    {
        // GET: ListaArtikala
        public ActionResult UnesiArtikal() 
        {
            ViewBag.Kategorije = new string[] { "Sport", "Glazba", "Tehnika" };
            return View(new Artikal());
        }

        // POST:
        [HttpPost]
        public ActionResult DodajArtikal(Artikal artikal)
        {
            if (Session["Artikli"] != null)
            {
                List<Artikal> artikli = (List<Artikal>)Session["Artikli"];
                artikli.Add(artikal);
                Session["Artikli"] = artikli;
            }
            else
            {
                List<Artikal> artikli = new List<Artikal>();
                artikli.Add(artikal);
                Session["Artikli"] = artikli;
            }
            return View(Session["Artikli"]);
        }
    }
}