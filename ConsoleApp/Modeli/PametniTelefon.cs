namespace ConsoleApp.Modeli;
public class PametniTelefon : ElektronickiUredjaj
{
    public string OperativniSustav { get; set; }

    public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
        : base(naziv, proizvodjac, godinaProizvodnje)
    {
        OperativniSustav = operativniSustav;
    }

    public void InstalirajAplikaciju(string operativniSustav)
    {
        base.IspisInformacije();
        Console.WriteLine($"\nInstaliranje aplikacije na {OperativniSustav} pametni telefon.");
    }
}
