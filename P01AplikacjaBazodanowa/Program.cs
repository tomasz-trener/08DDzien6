using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaBazodanowa
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // służy do komunikacji  z bazą 
            SqlCommand command; // przechowuje polcenia SQL 
            SqlDataReader dataReader;// czytanie wynik z bazy
                                     // 

            string connString = "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;User ID=tomasz1_alxalx;Password=Alxalx1!";
            //string connString = @"Data Source=.\sqlexpress;Initial Catalog=a_zawodnicy;integrated security=true";

            connection = new SqlConnection(connString);

            command = new SqlCommand("SELECT  * from zawodnicy", connection);
            connection.Open();

            dataReader=  command.ExecuteReader(); // wysylamy polecenie do bazy danych 

            int liczbaKolumn = dataReader.FieldCount;
            Console.WriteLine($"liczba kolumn wynosi: {liczbaKolumn}");

            while (dataReader.Read()) // czyta kolejny wiersz
            {
                string wynik = (string)dataReader.GetValue(2) + (string)dataReader.GetValue(3);
                Console.WriteLine(wynik);

            }

            connection.Close();
            Console.ReadKey();

        }
    }
}
