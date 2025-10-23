using ConsoleApp.Modeli;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod proizvod1 = new Proizvod("Laptop", 1200.50m, 10);
            Proizvod proizvod2 = new Proizvod("Televizija", 800.00m, 25);

            proizvod1.PrikaziInformacije();
            proizvod2.PrikaziInformacije();

            ElektronickiUredjaj uredjaj = new ElektronickiUredjaj("Tablet", "Samsung", 2022);
            uredjaj.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("iPhone 13", "Apple", 2021, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju(telefon.OperativniSustav);
        }
    }
}
