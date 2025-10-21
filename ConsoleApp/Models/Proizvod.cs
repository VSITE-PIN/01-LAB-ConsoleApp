namespace ConsoleApp.Models
{
    internal class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void IspisInformacije()
        {
            Console.WriteLine($"\n\t\t====Informacije o proizvodu====\nNaziv:" +
                $" {Naziv}\nCijena: {Cijena} EUR \nDostupna kolicina: {DostupnaKolicina} kom.");
        }

    }
}