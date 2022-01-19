using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07IntrefejsyPrzyklad
{
    class SystemObliczeniowy
    {

        public double WykonajOperacje(int a, int b, IUmiejacyWykonywacOperacje mechanizm)
        {
            double wynik = mechanizm.WykonajOperacje(a, b);
            return wynik;
        }

    }
}
