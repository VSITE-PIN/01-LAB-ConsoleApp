using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.modeli
{
    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }

        public string Proizvodjac { get; set; }

        public int godinaProizvodnje { get; set; }

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaproizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            godinaProizvodnje = godinaproizvodnje;
        }


        public void IspisiInformacije()
        {
            Console.WriteLine($"Elektronicki uredjaj: {Naziv}, {Proizvodjac}, {godinaProizvodnje}");

        }
    }
}

