﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Core
{
    class ZawodnicyRepository : IDostepDoDanych
    {
        public void Dodaj(Zawodnik z)
        {
            throw new NotImplementedException();
        }

        public void Edytuj(Zawodnik z)
        {
            throw new NotImplementedException();
        }

        public Zawodnik PodajZawodnika(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik = pzb.WykonajPolecenieSQL($"SELECT id_zawodnika, id_trenera,imie,nazwisko,kraj,data_ur,wzrost,waga from zawodnicy where id_zawodnika={id}");
            return MapujZawodnik(wynik)[0];
        }

        public void Usun(int id)
        {
            throw new NotImplementedException();
        }

        public Zawodnik[] WygenerujZawodnikow(string[] kolumny)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik = pzb.WykonajPolecenieSQL("SELECT id_zawodnika, id_trenera,imie,nazwisko,kraj,data_ur,wzrost,waga from zawodnicy");
            return MapujZawodnik(wynik);
        }
        private Zawodnik[] MapujZawodnik(object[][] wynik)
        {
            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
            {
                Zawodnik z = new Zawodnik();

                z.Id_zawodnika = (int)wynik[i][0];
                z.Id_trenera = (int)wynik[i][1];
                z.Imie = (string)wynik[i][2];
                z.Nazwisko = (string)wynik[i][3];
                z.Kraj = (string)wynik[i][4];
                z.DataUrodzenia = (DateTime)wynik[i][5];
                z.Wzrost = (int)wynik[i][6];
                z.Waga = (int)wynik[i][7];

                zawodnicy[i] = z;
            }
            return zawodnicy;
        }
    }
}
