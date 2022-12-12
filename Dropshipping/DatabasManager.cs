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
//här är en metod som lägger till produkter i databasen
        public void InsertProducts(Products products)
        {

            string sql = @"
                      INSERT INTO `products`
                      (name, price, description, isHot, onSale, image, weight, sellingPrice, manufacturer)
                      VALUES
                      (@Name, @Price, @Description, @IsHot, @OnSale, @Image, @Weight, @SellingPrice, @Manufacturer)";


            connection.Execute(sql, products);



        }
        //här är en metod som hämtar alla produkter från databasen
        public List<Products> GetProducts()
        {
            return connection.Query<Products>("SELECT * FROM Products").ToList();
        }
        //här är en metod som uppdaterar Customers
        public void UpdateCustumers(Customers custumers)
        {

            string sql = @"
                      UPDATE `custumers`
                      SET userName = @UserName, password = @Password
                      WHERE id = '1'";
            connection.Execute(sql, custumers);


        }

    }
}

