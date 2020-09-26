using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCrudiMat.Shared
{
	public class Osoba
	{
		public int ID { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }

		public string Grad { get; set; }
		public string PObox { get; set; }
		public string Ulica { get; set; }
		public string Broj { get; set; }

		public string ImeiPrezime { get => $"{Ime} {Prezime}"; }
		public string Adresa { get => $"{PObox} {Grad} {Ulica} {Broj}"; }

	}
}
