namespace ConsoleApp.modeli
{
    internal class PametniTelefon : ElektronickiUredaj
    {
        public string operativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodac, int godProizvodnje, string operativniSustav)
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