using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ZAD
            Console.WriteLine("ZADATAK 1: PROIZVOD");
            Proizvod mojProizvod = new Proizvod("Laptop", 850.50m, 10);
            mojProizvod.IspisInformacije();

            Console.WriteLine("\n------------------------------\n");

            // 2. ZAD
            Console.WriteLine("ZADATAK 2: PAMETNI TELEFON");
            PametniTelefon mojTelefon = new PametniTelefon("iPhone 15", "Apple", 2023, "iOS");
            mojTelefon.IspisInformacije();
            mojTelefon.InstalirajAplikaciju("WhatsApp");

            Console.WriteLine("\nPritisnite bilo koju tipku za kraj...");
            Console.ReadKey();
        }
    }
}