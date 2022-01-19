using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Core.Errors
{
    public class NiepoprawnaSciezkaException : Exception
    {
        public NiepoprawnaSciezkaException(string tresc) :base(tresc)
        {
            
        }
    }
}
