using Dapper;
using MySqlConnector;

namespace DropShipping
{

    public class DatabasManager
    {
        //Databas anslutning
        public MySqlConnection connection;

         //Ansluter till Databasen
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
//här är en metod som lägger till produkter i databasen (om vi hade velat göra det i c# istället för i mysql)
        public void InsertProducts(Product products)
        {
            string sql = @"
                      INSERT INTO `products`
                      (name, price, description, isHot, onSale, image, weight, sellingPrice, manufacturer)
                      VALUES
                      (@Name, @Price, @Description, @IsHot, @OnSale, @Image, @Weight, @SellingPrice, @Manufacturer)";
            connection.Execute(sql, products);
        }
      
      //här är en metod som lägger till en order i databasen
        public void InsertOrder(Order order)
        {
            string sql = @"
                      INSERT INTO `order`
                      (customerId, orderDate, orderStatus, orderPrice, shippingDate, shippingStatus)
                      VALUES
                      (@CustomerId, @OrderDate, @OrderStatus, @OrderPrice, @ShippingDate, @ShippingStatus);
                      SELECT LAST_INSERT_ID()";
            order.Id = connection.QuerySingle<int>(sql, order);
            foreach (var item in order.Products)
            {
                InsertOrderProduct(order.Id, item.Id);
            }
        }

        private void InsertOrderProduct(int orderId, int productId)
        {
            string sql = @"
                      INSERT INTO `products_to_order`
                      (orderId, productId)
                      VALUES
                      (@OrderId, @ProductId)";
            connection.Execute(sql, new { OrderId = orderId, ProductId = productId });
        }

        public List<Order> GetOrder()
        {
            string sql = "SELECT * FROM `order` WHERE CustumerId = @CustomerId";
            return connection.Query<Order>(sql, new { CustomerId = 1 }).ToList();
            }
      
        //här är en metod som hämtar alla produkter från databasen
        public List<Product> GetProducts()
        {
            return connection.Query<Product>("SELECT * FROM Products").ToList();
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
        /*   public Order GetProductsAndOrder(Product products, Order order)
        {
            return connection.Query<Order, Product, Order>(@"SELECT * FROM Order o
                                              INNER JOIN Products_to_Order po
                                              ON o.id = po.OrderId
                                              INNER JOIN Products p 
                                              ON po.ProductId = p.id
                                              WHERE o.id = @OrderId", new { OrderId = 1 }).ToList();
                                             
        }   */

    }
}

