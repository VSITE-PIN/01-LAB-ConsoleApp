using ConsoleApp.Modeli;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("HP 255 G10", 477.00m, 8);
            proizvod.IspisInformacije();

            ElektronickiUredjaj uredjaj = new ElektronickiUredjaj("Tablet", "Samsung", 2022);
            uredjaj.IspisInformacije();

            PametniTelefon mobitel = new PametniTelefon("Xiaomi 15", "Xiaomi", 2024, "Android");
            mobitel.IspisInformacije();
            mobitel.InstalirajAplikaciju(mobitel.OperativniSustav);

        }
    }
}