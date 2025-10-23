namespace ConsoleApp.Modeli;

public class Proizvod
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

    public void IspisiInformacije()
    {
        Console.WriteLine($"Proizvod: {Naziv}, Cijena: {Cijena}, Dostupna količina: {DostupnaKolicina}");
    }
}
