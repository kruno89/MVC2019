using Ispit_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Ispit_MVC.Controllers
{
    public class PoklonController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Poklon
        public ActionResult Index()
        {
            List<Poklon> dostupan = (from p in _db.Pokloni where p.Kupljen == false select p).ToList();

            return View(dostupan);
        }

        // GET: svi pokloni
        public ActionResult CompletePoklonList()
        {
            List<Poklon> lPokloni = (from p in _db.Pokloni select p).ToList();
            return View(lPokloni);
        }
        // GET: Poklon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poklon poklon = _db.Pokloni.Find(id);
            if (poklon == null)
            {
                return HttpNotFound();
            }
            return View(poklon);
        }

        // GET: Kontakt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kontakt/Create
        [HttpPost]
        public ActionResult Create(Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                _db.Pokloni.Add(poklon);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(poklon);
        }

        // GET: Kontakt/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poklon poklon = _db.Pokloni.Find(id);
            if (poklon == null)
            {
                return HttpNotFound();
            }
            return View(poklon);
        }

        // POST: Kontakt/Edit/5
        [HttpPost]
        public ActionResult Edit(Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(poklon).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(poklon);
        }

        // GET: Kontakt/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poklon poklon = _db.Pokloni.Find(id);
            if (poklon == null)
            {
                return HttpNotFound();
            }
            return View(poklon);
        }

        // POST: Kontakt/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Poklon poklon = _db.Pokloni.Find(id);
            _db.Pokloni.Remove(poklon);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}