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
    internal class ProductsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=register;";

        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM products", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product a = new Product
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDouble(2),
                        Barcode = reader.GetString(3),
                        Notes = reader.GetString(4),
                    };

                    products.Add(a);
                }
            }
            connection.Close();

            return products;

        }
        public Product getProductFromBarcode(string barcode)
        {
            Product product = new Product();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command  = new MySqlCommand("SELECT * FROM products WHERE BAR_CODE = @search", connection);
            command.Parameters.AddWithValue("@search", barcode.ToString());
            command.Connection = connection;


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product a = new Product
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDouble(2),
                        Barcode = reader.GetString(3),
                        Notes = reader.GetString(4),
                    };

                    product = a;
                }
            }
            connection.Close();

            return product;
        }
    }
}

