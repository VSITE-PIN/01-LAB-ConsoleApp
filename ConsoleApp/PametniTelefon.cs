namespace ConsoleApp
{
    public class PametniTelefon : ElektronickiUredjaj
    {
        // Dodatno svojstvo
        public string OperativniSustav { get; set; }

        // Konstruktor izvedene klase
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

        // Metoda specifična za PametniTelefon
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalira se aplikacija: {nazivAplikacije}");
        }

        // Ispis detalja uređaja uključujući OS
        public void IspisiDetaljeTelefona()
        {
            IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }
}