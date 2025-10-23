using ConsoleApp.Modeli;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod proizvod = new Proizvod("Laptop", 7500.00m, 10);
            proizvod.IspisiInformacije();

            ElektronickiUredjaj uredjaj = new ElektronickiUredjaj("Tablet", "Samsung", 2022);
            uredjaj.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("iPhone 13", "Apple", 2021, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju(telefon.OperativniSustav);
        }
    }
}
