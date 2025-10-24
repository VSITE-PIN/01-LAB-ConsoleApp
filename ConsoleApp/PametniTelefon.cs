using System;

namespace ConsoleApp
{
    internal class PametniTelefon : ElektronickiUredjaj
    {
        // Svojstvo
        public string OperativniSustav { get; set; }

        // Konstruktor
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

        // Metoda
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije}");
        }

        // Override metode
        public new void PrikaziInformacije()
        {
            base.PrikaziInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }
}
