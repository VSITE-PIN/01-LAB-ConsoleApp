using ConsoleApp.Modeli;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod proizvod = new Proizvod("Laptop", 7500, 10);
            proizvod.PrikaziInfo();

            ElektronickiUredaj uredaj = new ElektronickiUredaj("Televizor", "Samsung", 2020);

            uredaj.PrikaziInfo();

            pametniTelefon telefon = new pametniTelefon("iPhone", "Apple", 2021, "iOS");   
            telefon.PrikaziInfo();
            telefon.InstalirajAplikaciju("WhatsApp");

        }
    }
}
