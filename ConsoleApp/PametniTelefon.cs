using System;

namespace ConsoleApp
{
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodjac, int godina, string os)
            : base(naziv, proizvodjac, godina)
        {
            OperativniSustav = os;
        }

        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instaliram aplikaciju {nazivAplikacije} na {OperativniSustav}.");
        }

        public override void IspisInformacije()
        {
            base.IspisInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }
}