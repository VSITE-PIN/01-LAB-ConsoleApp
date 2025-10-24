using System;

namespace ConsoleApp
{
    
    class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        
        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }
        
        var mob = new PametniTelefon("Iphone 15 pro max", "Samsung", 2024, "Android");
        mob.IspisiInformacije();
mob.InstalirajAplikaciju("Viber");

        
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena} EUR, Dostupna količina: {DostupnaKolicina}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Proizvod p = new Proizvod("Laptop", 999.99m, 5);

            
            p.IspisiInformacije();

            Console.ReadLine(); 
        }
    }
}
