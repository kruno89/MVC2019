using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class CheckoutController : Controller
    {
        private WebShopEntities db = new WebShopEntities();


        // GET: Checkout
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUser([Bind(Include ="Id,Ime,Prezime,Email,AdresaDostave,Kontakt,Napomena")] Korisnici korisnici)
        {
            if (ModelState.IsValid)
            {
                db.Korisnicis.Add(korisnici);
                db.SaveChanges();
                return RedirectToAction("CreateOrder", korisnici);
            }

            return View(korisnici);
        }

        public ActionResult CreateOrder(Korisnici korisnici)
        {
            Narudzbe narudzba = new Narudzbe();
            narudzba.KorisnikId = korisnici.Id;
            narudzba.DatumKreiranja = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}