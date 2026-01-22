using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	internal class PametniTelefon : ElektronickiUredaj
	{
		public string OperativniSustav { get; set; }
		public PametniTelefon(string Naziv, string Proizvodac, int GodinaProizvodnje, string operativniSustav) : base(Naziv, Proizvodac, GodinaProizvodnje)
		{ OperativniSustav = operativniSustav; }

		public override void InstalirajAplikaciju()
		{
			Console.WriteLine($"Naziv: {Naziv}");
		}
	}
}