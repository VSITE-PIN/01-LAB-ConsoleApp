using System;

namespace ConsoleApp
{
    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godina)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godina;
        }

        public virtual void IspisInformacije()
        {
            Console.WriteLine($"Uredjaj: {Naziv}, Proizvodjac: {Proizvodjac}, Godina: {GodinaProizvodnje}");
        }
    }
}