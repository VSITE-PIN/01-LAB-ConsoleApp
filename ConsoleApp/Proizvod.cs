namespace ConsoleApp
{
    public class Proizvod
    {
        // Svojstva (properties)
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        // Konstruktor
        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        // Metoda za ispis informacija o proizvodu
        public void PrikaziInformacije()
        {
            Console.WriteLine("———————————————");
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena} Eura");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

}