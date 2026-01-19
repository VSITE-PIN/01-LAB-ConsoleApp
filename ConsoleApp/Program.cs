namespace ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			ProizvodBase proizvod1 = new ProizvodBase("Laptop", 1200, 10);

			proizvod1.PrikazInformacije();

			ElektronickiUredjaji elektronickiUredjaji = new PametniTelefon("tablet", "Samsung", 2022, "Android");

			elektronickiUredjaji.IspisiInformacije();

		}
	}
}
