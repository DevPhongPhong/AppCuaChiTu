using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuaChiTu
{
    public class Repo
    {
        public Repo()
        {
            string connectionString = "Data Source=d:/appcuachitu.sqlite;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandString = "SELECT * FROM products";
                using (var command = new SQLiteCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int price = reader.GetInt32(2);
                            Console.WriteLine($"Id: {id}, Name: {name}, Price: {price}");
                        }
                    }
                }
            }
        }
    }
}
