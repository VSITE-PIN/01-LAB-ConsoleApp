namespace ConsoleApp.Modeli
{
    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        public virtual void IspisInformacije()
        {
            Console.WriteLine("\nInformacije o proizvodu\n" + "-------------------------\n");
            Console.WriteLine("Naziv: " + Naziv);
            Console.WriteLine("Proizvođač: " + Proizvodjac);
            Console.WriteLine("Godina proizvodnje: " + GodinaProizvodnje);
        }
    }
}