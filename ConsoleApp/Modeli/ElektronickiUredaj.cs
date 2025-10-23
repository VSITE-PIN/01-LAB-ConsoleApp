using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Modeli
{
    internal class ElektronickiUredaj
    {
        public string Naziv { get; set; }
        public string Proizvodac { get; set; }

        public int GodProizvodnje { get; set; }

        public ElektronickiUredaj(string naziv, string proizvodac, int godProizvodnje)
        {
            Naziv = naziv;
            Proizvodac = proizvodac;
            GodProizvodnje = godProizvodnje;
        }

        public void PrikaziInfo()
        {
            Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodac}, Godina proizvodnje: {GodProizvodnje}");
        }
    }
}
