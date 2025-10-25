namespace ConsoleApp
{
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"instalira se app: {nazivAplikacije}");
        }

        public void IspisiDetaljeTelefona()
        {
            IspisiInformacije();
            Console.WriteLine($"operativni sustav: {OperativniSustav}");
        }
    }
}