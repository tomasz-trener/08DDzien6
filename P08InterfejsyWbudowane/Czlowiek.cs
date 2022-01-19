using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08InterfejsyWbudowane
{
    class Czlowiek : IComparable
    {
        public string Imie;
        public int Wzorst;

        public int CompareTo(object obj)
        {
            Czlowiek tenInnyCzlowiek = (Czlowiek)obj;

            return this.Imie.Length - tenInnyCzlowiek.Imie.Length;
        }
    }
}
