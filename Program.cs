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

            string connect_info = "server=localhost;user=root;database=people;password=1234;";



            MySqlConnection connection = new MySqlConnection(connect_info);

            connection.Open();

            string query = "INSERT INTO `people`.`students` (`id`, `name`, `age`) VALUES ('1', 'Max', '18');";



            MySqlCommand command = new MySqlCommand(query, connection);


           command.ExecuteNonQuery();
            connection.Close();


        }
    }
}
