using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vareprogram
{
    internal class Vare
    {
        public int VareNr { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }
        public int Antal { get; set; }

        public Vare(int vareNr, string navn, double pris, int antal)
        {
            VareNr = vareNr;
            Navn = navn;
            Pris = pris;
            Antal = antal;
        }
    }
}
