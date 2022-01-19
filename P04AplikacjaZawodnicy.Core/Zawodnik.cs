using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Core
{

    public class Zawodnik : IComparable
    {
        public int Id_zawodnika; // domyślna wartośc int =0
        public int Id_trenera;
        public string Imie; // domyslna wartosc string =null
        public string Nazwisko { get; set; }
        public string Kraj;
        public DateTime DataUrodzenia; // domyslna wartośc Datetime = /1.1.0001
        public int Wzrost;
        public int Waga;
        public static string[] KolumnyZWidoku;
        public static string DomysleSortowanie;
        public static Kolumna[] Kolumny
        {
            get
            {
                return new Kolumna[]
                {
                   new Kolumna() { Nazwa= "Imie",Widocznosc=true },
                   new Kolumna() { Nazwa= "Nazwisko",Widocznosc=true },
                   new Kolumna() { Nazwa= "Kraj",Widocznosc=false },
                   new Kolumna() { Nazwa= "DataUrodzenia",Widocznosc=false },
                   new Kolumna() { Nazwa= "Wzrost",Widocznosc=false },
                   new Kolumna() { Nazwa= "Waga",Widocznosc=false },
                };
            }
        }

        public string WidoczneKolumny
        {
            get
            {
                string s = "";
                if (KolumnyZWidoku.Contains("Imie"))
                    s += Imie + " ";
                if (KolumnyZWidoku.Contains("Nazwisko"))
                    s += Nazwisko + " ";
                if (KolumnyZWidoku.Contains("Kraj"))
                    s += Kraj + " ";
                if (KolumnyZWidoku.Contains("DataUrodzenia"))
                    s += DataUrodzenia + " ";
                if (KolumnyZWidoku.Contains("Wzrost"))
                    s += Wzrost + " ";
                if (KolumnyZWidoku.Contains("Waga"))
                    s += Waga + " ";

                return s;
            }
        }

        public string DataUrodzeniaFormat
        {
            get { return DataUrodzenia.ToString("yyyy-MM-dd"); }
        }


        public string Wiersz
        {
            get
            {
                return $"{Id_zawodnika};{Id_trenera};{Imie};{Nazwisko};{Kraj};{DataUrodzeniaFormat};{Wzrost};{Waga}";
            }
        }

        public string ImieNazwisko { get { return Imie + " " + Nazwisko; } }


        public Zawodnik()
        {

        }
 

        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam się {Imie} {Nazwisko} i pochodzę z {Kraj}";
        }

        public int CompareTo(object obj)
        {
            Zawodnik inny = (Zawodnik)obj;
            if (DomysleSortowanie == "id_zawodnika")
                return Id_zawodnika = inny.Id_zawodnika;
            if (DomysleSortowanie == "id_trenera")
                return Id_trenera = inny.Id_trenera;
            if (DomysleSortowanie == "imie")
                return Imie.CompareTo(inny.Imie);
            if (DomysleSortowanie == "nazwisko")
                return Nazwisko.CompareTo(inny.Nazwisko);
            if (DomysleSortowanie == "kraj")
                return Kraj.CompareTo(inny.Kraj);
            if (DomysleSortowanie == "data_ur")
                return DataUrodzenia.CompareTo(inny.DataUrodzenia);
            if (DomysleSortowanie == "wzrost")
                return Wzrost - inny.Wzrost;
            if (DomysleSortowanie == "waga")
                return Waga = inny.Waga;

            return 0;
        }
    }
}
