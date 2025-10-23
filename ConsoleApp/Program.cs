namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod proizvod = new Proizvod("Laptop", 7500, 10);
            proizvod.PrikaziInfo();
        }
    }
}
