namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            ProizvodBase proizvod1 = new ProizvodBase("Laptop", 1200, 10);
            proizvod1.PrikazInformacije();


            ElektronickiUredjaji elektronskiUredjaj1 = new PametniTelefon("Tablet", "Samsung", 2022, "Android");
            elektronskiUredjaj1.IspisiInformacije();
        }
    }
}