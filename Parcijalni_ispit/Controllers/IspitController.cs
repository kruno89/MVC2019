using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcijalni_ispit.Controllers
{
    public class IspitController : Controller
    {
        // GET: Ispit
        public ViewResult Prvi()
        {
            ViewBag.Vrijeme = DateTime.Now;
            return View();
        }
    }
}