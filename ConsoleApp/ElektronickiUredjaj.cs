namespace ConsoleApp
{
    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }
        public string Proizvodac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public ElektronickiUredjaj(string naziv, string proizvodac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodac = proizvodac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodac}, Godina Proizvodnje: {GodinaProizvodnje}");
        }
    }
}
