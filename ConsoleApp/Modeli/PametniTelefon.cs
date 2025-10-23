namespace ConsoleApp.Modeli;

public class PametniTelefon : ElektronickiUredjaj
{
    public string OperativniSustav { get; set; }

    public PametniTelefon(string naziv, string proizvodac, int godinaProizvodnje, string operativniSustav)
        : base(naziv, proizvodac, godinaProizvodnje)
    {
        OperativniSustav = operativniSustav;
    }

    public void InstalirajAplikaciju(string operativniSustav)
    {
        Console.WriteLine($"Instaliranje aplikacije na {operativniSustav} pametni telefon.");
    }
}