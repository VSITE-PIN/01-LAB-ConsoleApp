namespace ConsoleApp
{
    internal class ProizvodBase
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, World!");
            Proizvod proizvod1 = new Proizvod("Laptop", 1200.50m, 10);
            Proizvod proizvod2 = new Proizvod("Pametni telefon", 800.00m, 25); 

            proizvod1.PrikazInformacije();
            proizvod2.PrikazInformacije();
        }
    }
}