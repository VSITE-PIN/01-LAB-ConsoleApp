using ConsoleApp.modeli;
using ConsoleApp.modeli;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            proizvod proizvod = new proizvod("Laptop", 7500, 10);
            proizvod.PrikaziInfo();

            ElektronickiUredaj uredaj = new ElektronickiUredaj("Televizor", "Samsung", 2020);

            uredaj.PrikaziInfo();

            PametniTelefon telefon = new PametniTelefon("iPhone", "Apple", 2021, "iOS");
            telefon.PrikaziInfo();
            telefon.InstalirajAplikaciju("WhatsApp");

        }
    }
}
