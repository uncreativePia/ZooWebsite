using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiasWebsite
{
	public class Zoo
	{
		public static List<PiasWebsite.Models.Tier> Tiere { get; set; } = new List<Models.Tier>();
		public static void AddTiere ()
		{
			var erstesTier = new Models.Tier();
			erstesTier.Tierart = "Hund";
			erstesTier.Name = "Jack";
			erstesTier.Groesse = 1.20f;
			erstesTier.Gewicht = 50;
			erstesTier.Geschlecht = "m";
			erstesTier.Herkunft = "DE";
			Tiere.Add(erstesTier);

			var zweitesTier = new Models.Tier();
			zweitesTier.Tierart = "Einhorn";
			zweitesTier.Name = "Helmut";
			zweitesTier.Groesse = 0.35f;
			zweitesTier.Gewicht = 50;
			zweitesTier.Geschlecht = "m";
			zweitesTier.Herkunft = "Neverland";
			Tiere.Add(zweitesTier);
		}
		public static List<PiasWebsite.Models.Mitarbeiter> Mitarbeiter { get; set; } = new List<Models.Mitarbeiter>();
		public static void AddMitarbeiter()
		{
			var ersterMitarbeiter = new Models.Mitarbeiter();
			ersterMitarbeiter.Name = "Jeff";
			ersterMitarbeiter.Geschlecht = "m";
			ersterMitarbeiter.Gehalt = 3500;
			Mitarbeiter.Add(ersterMitarbeiter);

			var zweiterMitarbeiter = new Models.Mitarbeiter();
			zweiterMitarbeiter.Name = "Marda";
			zweiterMitarbeiter.Geschlecht = "w";
			zweiterMitarbeiter.Gehalt = 2900;
			Mitarbeiter.Add(zweiterMitarbeiter);
		}
		public static List<PiasWebsite.Models.Gehege> Gehege { get; set; } = new List<Models.Gehege>();
		public static void AddGehege()
		{
			var erstesGehege = new Models.Gehege();
			erstesGehege.GehegeArt = "Gemüsebeet";
			erstesGehege.Tier = "Schnecke";
			Gehege.Add(erstesGehege);

			var zweitesGehege = new Models.Gehege();
			zweitesGehege.GehegeArt = "Wolken";
			zweitesGehege.Tier = "Einhorn";
			Gehege.Add(zweitesGehege);
		}
	}
}