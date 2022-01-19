using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07IntrefejsyPrzyklad
{
    class SystemOdejmowania : IUmiejacyWykonywacOperacje
    {
        public double WykonajOperacje(int a, int b)
        {
            return a - b;
        }
    }
}
