namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZAdatak 1: Klase i objekti");

            // Primjer iz prve vježbe
            Proizvod proizvod1 = new Proizvod("Laptop", 1200.00m, 10);
            Proizvod proizvod2 = new Proizvod("Televizija", 800.00m, 25);

            proizvod1.PrikaziInformacije();
            proizvod2.PrikaziInformacije();

            Console.WriteLine();
            Console.WriteLine("Zadatak 2: Nasljeđivanje");

            // Primjer iz druge vježbe
            PametniTelefon telefon = new PametniTelefon("iPhone 15", "Apple", 2023, "iOS 17");
            telefon.IspisiDetaljeTelefona();
            telefon.InstalirajAplikaciju("Instagram");

            Console.ReadLine();
        }
    }
}