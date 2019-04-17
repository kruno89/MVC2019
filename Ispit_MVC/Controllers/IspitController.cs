using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ispit_MVC.Controllers
{
    public class IspitController : Controller
    {
        
        public ViewResult Prvi()
        {
            ViewBag.Vrijeme = DateTime.Now;
            return View();
        }
    }
}