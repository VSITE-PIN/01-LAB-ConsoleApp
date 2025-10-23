namespace ConsoleApp.modeli
{
    public class proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public proizvod (string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void PrikaziInfo()
        {
            Console.WriteLine($"Proizvod: {Naziv}, Cijena: {Cijena:C}, Dostupna količina: {DostupnaKolicina}");
        }
    }
}