using ConsoleApp.modeli;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvodi proizvod1 = new Proizvodi("Laptop", 7500, 10);
            proizvod1.IspisiInformacije();

            ElektronickiUredjaj uredjaj = new ElektronickiUredjaj("Tablet", "Samsung", 2022);
            uredjaj.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("iPhone 13", "Apple", 2021, "IOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju(telefon.OperativniSustav);
        }
    }
}
