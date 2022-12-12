using Dapper;
using MySqlConnector;

namespace DropShipping
{

    public class DatabasManager
    {

        public MySqlConnection connection;

        public DatabasManager()
        {

            connection = new MySqlConnection("Server=localhost;Database=Dropshipping;Uid=root;");
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void InsertProducts(Products products)
        {

            string sql = @"
                      INSERT INTO `products`
                      (name, price, description, isHot, onSale, image, weight, sellingPrice, manufacturer)
                      VALUES
                      ('Knife', '150', 'This is a very sharp knife!', TRUE, FALSE, 'No', '0.7', '250', 'Alibaba'";
            
            
            connection.Execute(sql, products);

            

        }
    }

}

