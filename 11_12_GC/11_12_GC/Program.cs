using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;

namespace _11_12_GC
{
    class Program
    {
        //SQL ADATBÁZIS
        //https://www.connectionstrings.com/
        //SQL Server
        static void Main(string[] args)
        {
            //@ = Összes utasítás ignorálása
            string connectionsString = @"Server = (localdb)\MSSQLLocalDB; Database=teszt";
            //SQL Server Object Explorer --> Adatbázis, lenyit --> Properties (másik ablak) - Connections String

            var connection = new SqlConnection(connectionsString);

            connection.Open();

            //SQL LEKÉRDEZÉS
            var sql = new SqlCommand("select * from nevek;", connection);
            //OLVASÓ
            SqlDataReader reader = sql.ExecuteReader();

            //PL: id, nev, ev
            //Ha az olvasó "Read" visszatér igazzal akkor tudott olvasni
            while (reader.Read())
            {
                Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");
            }
            connection.Close();
            Console.ReadKey();
        }
    }
}
