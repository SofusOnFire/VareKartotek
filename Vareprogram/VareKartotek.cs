using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vareprogram
{
    internal class VareKartotek
    {
        public List<Vare> VareListe { get; set; }

        public VareKartotek(List<Vare> vareListe)
        {
            VareListe = vareListe;
        }

        public void IndSaet(Vare vare)
        {
            VareListe.Add(vare);
        }

        public void Slet(int vareNr)
        {
            foreach (Vare vare in VareListe)
            {
                if(vare.VareNr == vareNr)
                {
                    VareListe.Remove(vare);
                    break;
                }
            }
        }

        public double BeregnVaerdi(VareKartotek vareKartotek)
        {
            double sum = 0;

            foreach (Vare vare in VareListe)
            {
                sum += vare.Pris;
            }

            return sum;
        }

        public void PrintVare(int vareNr)
        {
            foreach (Vare vare in VareListe)
            {
                if (vare.VareNr == vareNr)
                {
                    Console.WriteLine("Varedetaljer:");
                    Console.WriteLine("Varenr.: " + vare.VareNr + "\nNavn: " + vare.Navn + "\nPris: " + vare.Pris + "\nAntal: " + vare.Antal);
                }
            }
        }
    }
}
