﻿using HtmlHelperi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperi.Controllers
{
    public class TemplHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ViewResult HtmlEditorView()
        {
            return View(new OsobaTempl());
        }

        [HttpPost]
        public ViewResult HtmlEditorView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }

        //GET METODA // skraćena verzija ovog gornjeg
        public ViewResult EditorModelView()
        {
            return View(new OsobaTempl());
        }

        [HttpPost]
        public ViewResult EditorModelView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}