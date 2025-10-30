namespace ConsoleApp
{
    public class ProizvodBase
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public ProizvodBase(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void PrikazInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena} Eura, Dostupna količina: {DostupnaKolicina}");
        }
    }
}