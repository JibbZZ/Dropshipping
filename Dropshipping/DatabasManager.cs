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
        //här är en metod som hämtar alla Customers från databasen

        public List<Customers> GetCustumers()
        {
            return connection.Query<Customers>("SELECT * FROM Custumers").ToList();
        }

        //här är en metod som uppdaterar Customers
        public void UpdateCustumers(Customers custumers)
        {

            string sql = @"
                      UPDATE `custumers`
                      SET userName = @UserName, password = @Password
                      WHERE id = @Id";
            connection.Execute(sql, custumers);
        }
        //här är en metod som inner joinar Products och order
       /*  public List<Products> GetProductsAndOrder(Products products, Order order)
        {
            return connection.Query<Products>(@"SELECT * FROM Order o
                                              INNER JOIN Products p 
                                              ON o.ProductId = p.id").ToList();
        } */

        

    }
}

