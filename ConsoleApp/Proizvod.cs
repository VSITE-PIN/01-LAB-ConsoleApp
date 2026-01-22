using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	internal class Proizvod
	{
		public string Naziv { get; set; }
		public decimal Cijena { get; set; }
		public int DostupnaKolicina { get; set; }
		public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
		{
			Naziv = naziv;
			Cijena = cijena;
			DostupnaKolicina = dostupnaKolicina;
		}


		public void IspisiInformacije()
		{
			Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena}eura, Dostupna količina: {DostupnaKolicina} komada");
		}
	}
}
