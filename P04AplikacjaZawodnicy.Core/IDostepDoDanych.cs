﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Core
{
    // intrefejs to tylko zestawienie sygnatur metod, które koniecznie mają być zaimplementowane przez naszą klasę 
    interface IDostepDoDanych
    {
        Zawodnik[] WygenerujZawodnikow(string[] kolumny);
        void Dodaj(Zawodnik z);
        void Edytuj(Zawodnik z);
        void Usun(int id);
        Zawodnik PodajZawodnika(int id);
    }
}