using PiasWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiasWebsite.Controllers
{
	public class GehegeController : Controller
	{
		// GET: Gehege
		public ActionResult Index()
		{
			return View("Index", Zoo.Gehege);
		}

		public ActionResult Create()
		{
			return View();

		}

		[HttpPost]
		public ActionResult Create(Gehege gehege)
		{
			Zoo.Gehege.Add(gehege);
			return RedirectToAction("Index");
		}
	}
}