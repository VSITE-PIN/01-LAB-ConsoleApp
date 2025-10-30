using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ElektronickiUredjaji
    {
        public string Naziv { get; set; }
        public string Proizvodac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public ElektronickiUredjaji(string naziv, string proizvodac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodac = proizvodac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Proizvodac: {Proizvodac}, Godina Proizvodnje: {GodinaProizvodnje}");
        }
    }
}