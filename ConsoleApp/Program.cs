namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zad 1
            Proizvod proizvod1 = new Proizvod("Laptop", 1400, 15);
            Proizvod proizvod2 = new Proizvod("Televizija", 500, 23);

            proizvod1.PrikaziInformacije();
            proizvod2.PrikaziInformacije();
            Console.WriteLine();

            // zad 2
            PametniTelefon telefon = new PametniTelefon("Pixel 9a", "Google", 2025, "Android 15");
            telefon.IspisiDetaljeTelefona();
            telefon.InstalirajAplikaciju("Threads");

            Console.ReadLine();
        }
    }
}