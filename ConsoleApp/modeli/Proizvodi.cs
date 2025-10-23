namespace ConsoleApp.modeli
{
    public class Proizvodi
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public Proizvodi(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }


        public void IspisiInformacije()
        {
            Console.WriteLine($"Proizvodi: {Naziv}, {Cijena}, {DostupnaKolicina}");
        }
    }
}
