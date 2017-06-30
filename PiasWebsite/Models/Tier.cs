using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiasWebsite.Models
{
	public class Tier
	{
		public string Tierart { get; set; }
		public string Name { get; set; }
		public float Groesse { get; set; }
		public float Gewicht { get; set; }
		public string Geschlecht { get; set; }
		public string Herkunft { get; set; }
	}
}