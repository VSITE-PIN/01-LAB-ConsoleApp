using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod01 = new Proizvod("Dell Vostro", 520.50m, 10);
            proizvod01.IspisInformacije();

            PametniTelefon tel01 = new PametniTelefon("Galaxy S25", "Samsung", 2025, "Android");
            tel01.IspisInformacije();
            tel01.InstalirajAplikaciju("WhatsApp");

        }
    }
}
