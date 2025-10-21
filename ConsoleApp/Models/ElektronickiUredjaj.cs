namespace ConsoleApp.Models
{
    internal class ElektronickiUredjaj
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
            Console.WriteLine($"\n\t\t====Informacije o uredjaju====\nNaziv uredjaja: {Naziv}\n" +
                $"Proizvodjac: {Proizvodjac} \nGodina proizvodnje: {GodinaProizvodnje}");
        }
    }
}
