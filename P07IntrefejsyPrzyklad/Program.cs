using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07IntrefejsyPrzyklad
{
    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy system do obliczen : 1) dodawanie, 2) odejmowanie, 3) mnozenie 4)  dzielenie 

            SystemObliczeniowy so = new SystemObliczeniowy();

            double wynik= so.WykonajOperacje(2, 3, new SystemOdejmowania());


            // 13:15
        }
    }
}
