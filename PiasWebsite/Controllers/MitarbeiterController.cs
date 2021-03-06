﻿using PiasWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiasWebsite.Controllers
{
    public class MitarbeiterController : Controller
    {
        // GET: Mitarbeiter
        public ActionResult Index()
        {
            return View("Index", Zoo.Mitarbeiter);
        }

		public ActionResult Create()
		{
			return View();

		}
		[HttpPost]
		public ActionResult Create(Mitarbeiter mitarbeiter)
		{
			Zoo.Mitarbeiter.Add(mitarbeiter);
			return RedirectToAction("Index");
		}
	}
}