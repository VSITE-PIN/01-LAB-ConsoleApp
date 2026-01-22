using System;

namespace ConsoleApp
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public Proizvod(string naziv, decimal cijena, int kolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = kolicina;
        }

        public void IspisInformacije()
        {
            Console.WriteLine($"Proizvod: {Naziv}, Cijena: {Cijena} EUR, Kolicina: {DostupnaKolicina}");
        }
    }
}