using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Intrefejsy
{
    class Amfibia : IUmejacyJezdzic, IUmiejacyPlywac
    {
        public void Plyn()
        {
            Console.WriteLine("Amfibia plynie");
        }

        public void Jedz()
        {
            Console.WriteLine("amfibia jedzie");
        }
    }
}
