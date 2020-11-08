using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {

            string connect_info = "server=localhost;username=host;database=people;pasword=1234;";



            MySqlConnection connection = new MySqlConnection(connect_info);

            connection.Open();


            connection.Close();


        }
    }
}
