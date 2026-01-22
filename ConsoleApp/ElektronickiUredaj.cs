using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	internal abstract class ElektronickiUredaj
	{
		public string Naziv { get; set; }
		public string Proizvodac { get; set; }
		public int GodinaProizvodnje { get; set; }
		public ElektronickiUredaj(string naziv, string proizvodac, int godinaProizvodnje)
		{
			Naziv = naziv;
			Proizvodac = proizvodac;
			GodinaProizvodnje = godinaProizvodnje;
		}

		public void IspisiInformacije()
		{
			Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodac}, Godina proizvodnje: {GodinaProizvodnje} g.");
		}
		public abstract void InstalirajAplikaciju();
	}
}
