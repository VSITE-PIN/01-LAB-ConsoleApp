using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PametniTelefon : ElektronickiUredjaji
    {
        public string OperativniSustav { get; set; }
        public PametniTelefon(string naziv, string proizvodac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }
    }
}