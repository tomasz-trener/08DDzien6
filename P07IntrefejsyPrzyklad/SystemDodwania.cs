using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07IntrefejsyPrzyklad
{
    class SystemDodwania : IUmiejacyWykonywacOperacje
    {
        public int Pole;

        public double WykonajOperacje(int a, int b)
        {
            return MojaMetoda(a, b);
        }


        private double MojaMetoda(int a, int b)
        {
            return a + b;
        }
    }
}
