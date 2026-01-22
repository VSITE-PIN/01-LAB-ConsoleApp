namespace ConsoleApp
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Proizvod proizvod1 = new Proizvod("Mobitel", 750, 10);
			Proizvod proizvod2 = new Proizvod("Televizor", 1000, 25);

			proizvod1.IspisiInformacije();
			proizvod2.IspisiInformacije();

			ElektronickiUredaj elektronickiUredjaj =
				new PametniTelefon("Tablet", "Samsung", 2022, "Android");

			elektronickiUredjaj.IspisiInformacije();
			elektronickiUredjaj.InstalirajAplikaciju();
		}
	}
}
