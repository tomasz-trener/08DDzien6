using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaOkienkowa
{
    class PolaczenieZBaza
    {
        string connString;

        public PolaczenieZBaza()
        {
            connString = "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;User ID=tomasz1_alxalx;Password=Alxalx1!";
        }

        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }

        public PolaczenieZBaza(string adresServera, string nazwaBazy)
        {
            connString = string.Format("Data Source={0};Initial Catalog={1};integrated security=true",
                adresServera, nazwaBazy);
        }

        public PolaczenieZBaza(string adresServera, string nazwaBazy, string nazwaUzytkownika, string haslo)
        {
            connString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                adresServera,  nazwaBazy,  nazwaUzytkownika, haslo);
        }



        public object[][] WykonajPolecenieSQL(string sql)
        {
            SqlConnection connection; // służy do komunikacji  z bazą 
            SqlCommand command; // przechowuje polcenia SQL 
            SqlDataReader dataReader;// czytanie wynik z bazy
                                     // 
            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);
            connection.Open();

            dataReader = command.ExecuteReader(); // wysylamy polecenie do bazy danych 

            int liczbaKolumn = dataReader.FieldCount;

            // zadanie: 
            //wygeneruj tablicę tablic przechodzac wiersz po wierszu, kolumna po kolumnie
            // tak aby wyniki byly przechowwane w tablicy tablic typu object 

            List<object[]> listaWierszy = new List<object[]>();

            while (dataReader.Read()) // czyta kolejny wiersz
            {
                object[] komorki = new object[liczbaKolumn];
                for (int i = 0; i < liczbaKolumn; i++)
                    komorki[i] = dataReader.GetValue(i);

                listaWierszy.Add(komorki);
            }

            connection.Close();

            return listaWierszy.ToArray();
        }


    }
}
