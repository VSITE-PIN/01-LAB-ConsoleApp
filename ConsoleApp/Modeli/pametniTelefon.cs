using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Modeli
{
    internal class pametniTelefon : ElektronickiUredaj
    {
        public string operativniSustav { get; set; }

        public pametniTelefon(string naziv, string proizvodac, int godProizvodnje, string operativniSustav)
            : base(naziv, proizvodac, godProizvodnje)
        {
            this.operativniSustav = operativniSustav;
        }

        public void InstalirajAplikaciju(string operativniSustav)
        {
            Console.WriteLine($"Instalirana aplikacija: {operativniSustav} na pametni telefon");
        }
    }
}
