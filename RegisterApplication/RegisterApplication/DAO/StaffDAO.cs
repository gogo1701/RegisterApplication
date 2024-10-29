using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using RegisterApplication.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                while (reader.Read())
                {
                    Staff a = new Staff
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Password = reader.GetString(2),
                        TypeStaff = reader.GetString(3)
                    };

                    staff.Add(a);
                }
            }
            connection.Close();

            return staff;

        }

        public Staff getStaffByName(string name)
        {
            Staff staff = new Staff();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `staff` WHERE FIRST_NAME = @search", connection);
            command.Parameters.AddWithValue("@search", name.ToString());
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Staff a = new Staff
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Password = reader.GetString(2),
                        TypeStaff = reader.GetString(3)
                    };

                    staff = a;
                }
            }
            connection.Close();

            return staff;

        }

        public bool isStaffManager(string username, string password)
        {
            Staff staff = new Staff();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM staff WHERE FIRST_NAME = @search", connection);
            command.Parameters.AddWithValue("@search", username.ToString());
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Staff a = new Staff
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Password = reader.GetString(2),
                        TypeStaff = reader.GetString(3)
                    };

                    staff = a;
                }
            }
            connection.Close();

            if(staff != null)
            {
                if(staff.TypeStaff == "Manager")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
         //   return staff;
        }
        public bool doesStaffExist(string username, string password)
        {
            Staff staff = new Staff();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM staff WHERE FIRST_NAME = @search", connection);
            command.Parameters.AddWithValue("@search", username.ToString());
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Staff a = new Staff
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        TypeStaff = reader.GetString(2)
                    };

                    staff = a;
                }
            }
            connection.Close();

            if (staff != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            //   return staff;
        }

    }
   
}
