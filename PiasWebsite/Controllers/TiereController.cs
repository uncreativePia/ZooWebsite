using PiasWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiasWebsite.Controllers
{
    public class TiereController : Controller
    {
        // GET: Tiere
        public ActionResult Index()
        {
            return View("Index", Zoo.Tiere);
        }

		public ActionResult Create()
		{
			return View();

		}
		[HttpPost]
		public ActionResult Create(Tier tier)
		{
			Zoo.Tiere.Add(tier);
			return RedirectToAction("Index");
		}
    }
}