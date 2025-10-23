using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.modeli
{
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativnisustav) 
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativnisustav;
        }

        public void InstalirajAplikaciju(string OperativniSustav)
        {
            Console.WriteLine($"Instaliranje aplikacije na {OperativniSustav} pametni telefon");
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Pametni Telefon: {Naziv}, {Proizvodjac}, {godinaProizvodnje}");
        }
    }
}
