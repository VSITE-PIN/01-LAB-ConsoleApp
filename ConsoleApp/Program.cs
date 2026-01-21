using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proizvod = new Proizvod("Laptop", 999.99m, 10);
            proizvod.IspisiInformacije();

            Console.WriteLine("Pritisnite Enter za izlaz...");
            Console.ReadLine();

            var tel = new PametniTelefon("Sony Xperia", "Sony", 2016, "Android");
            tel.IspisiInformacije();                 
            tel.InstalirajAplikaciju("WhatsApp");    

            Console.WriteLine("Pritisnite Enter za izlaz...");
            Console.ReadLine();
        }
    }
}