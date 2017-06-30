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
	}
}