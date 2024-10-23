using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using RegisterApplication.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterApplication.DAO
{
    internal class StaffDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=register;";

        public List<Staff> getAllStaff()
        {
            List<Staff> staff = new List<Staff>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM staff", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Staff a = new Staff
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        TypeStaff = reader.GetString(2)
                    };

                    staff.Add(a);
                }
            }
            connection.Close();

            return staff;

        }
    }
}
