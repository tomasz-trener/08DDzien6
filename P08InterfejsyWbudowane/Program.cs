using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08InterfejsyWbudowane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 5, 7, 8, 31, 1 };

            Array.Sort(liczby);

            Console.WriteLine(string.Join(" ", liczby));

            Czlowiek[] osoby = new Czlowiek[]
            {
                new Czlowiek(){ Imie = "Adam", Wzorst=180},
                new Czlowiek(){ Imie = "Lukasz", Wzorst=180},
                new Czlowiek(){ Imie = "Jan", Wzorst=180},
            };

            Array.Sort(osoby);

            foreach (var s in osoby)
            {
                Console.WriteLine(s.Imie);
            }

            Console.ReadKey();

        }
    }
}
