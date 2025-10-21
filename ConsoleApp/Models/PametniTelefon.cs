namespace ConsoleApp.Models
{
    internal class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
            OperativniSustav = operativniSustav;
        }

        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"\nInstalirana aplikacija: {nazivAplikacije}");
        }

        public override void IspisInformacije()
        {
            base.IspisInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }

    }
}
