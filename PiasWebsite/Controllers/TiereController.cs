using PiasWebsite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiasWebsite.Controllers
{
    public class TiereController : Controller
    {
		private int i;

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
			SpeicherTiere(Zoo.Tiere);
			return RedirectToAction("Index");
		}

		private void SpeicherTiere(List<Tier> tiere)
		{
			string content = "";

			

			for (int i = 0; i < tiere.Count; i++)
			{
				var tier = tiere[i];

				content = content + "-\r\n";
				content = content + "Tierart:" + tier.Tierart + "\r\n";
				content = content + "Name:" + tier.Name + "\r\n";
				content = content + "Groesse:" + tier.Groesse + "\r\n";
				content = content + "Gewicht:" + tier.Gewicht + "\r\n";
				content = content + "Geschlecht:" + tier.Geschlecht + "\r\n";
				content = content + "Herkunft:" + tier.Herkunft + "\r\n";

				

			}

			var Pfad = Server.MapPath("~/App_Data/Tiere.txt");
			System.IO.File.WriteAllText(Pfad, content);
		}
	}
}