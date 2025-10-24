using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");

            Proizvod proizvod1 = new Proizvod("Laptop", 1200.50m, 10);
            Proizvod proizvod2 = new Proizvod("Televizija", 800.00m, 5);

            proizvod1.PrikaziInformacije();
            proizvod2.PrikaziInformacije();

            Console.WriteLine("--------------------------------");

            ElektronickiUredjaj uredjaj = new ElektronickiUredjaj("Mikser", "Bosch", 2020);
            uredjaj.PrikaziInformacije();

            Console.WriteLine("--------------------------------");

            PametniTelefon telefon = new PametniTelefon("iPhone 15", "Apple", 2024, "iOS 17");
            telefon.PrikaziInformacije();
            telefon.InstalirajAplikaciju("Instagram");

            Console.WriteLine("\nPritisni bilo koju tipku za izlaz...");
            Console.ReadKey();
         }

    }
   
}
   

