namespace ConsoleApp.Modeli;

public class ElektronickiUredjaj
{
    public string Naziv { get; set; }
    public string Proizvodac { get; set; }
    public int GodinaProizvodnje { get; set; }

    public ElektronickiUredjaj(string naziv, string proizvodac, int godinaProizvodnje)
    {
        Naziv = naziv;
        Proizvodac = proizvodac;
        GodinaProizvodnje = godinaProizvodnje;
    }

    public void IspisiInformacije()
    {
        Console.WriteLine($"Uređaj: {Naziv}, Proizvođač: {Proizvodac}, Godina proizvodnje: {GodinaProizvodnje}");
    }
}