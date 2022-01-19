using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Intrefejsy
{
    class Hydroplan : IUmiejacyPlywac, IUmiejacyLatac
    {
        public void Lec()
        {
            Console.WriteLine("Hydroplan leci ");
        }

        public void Plyn()
        {
            Console.WriteLine("hydroplan plynie");
        }
    }
}
