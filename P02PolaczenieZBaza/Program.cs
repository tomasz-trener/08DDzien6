using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaOkienkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik = pzb.WykonajPolecenieSQL("select imie, nazwisko,kraj from zawodnicy order by kraj");

            for (int i = 0; i < wynik.Length; i++)
                Console.WriteLine(string.Join(" ",wynik[i]));

            Console.ReadKey();
        }
    }
}
