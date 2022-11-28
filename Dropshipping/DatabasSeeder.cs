using MySqlConnector;
using Dapper;

namespace DropShipping
{
    internal class DatabaseSeeder
    {
        public MySqlConnection connection;

        public DatabaseSeeder(MySqlConnection connection)
        {
            this.connection = connection;

        }
        public List<Products> CreateProductTable(Products products)
        {
            connection.Execute(@"CREATE TABLE Products
                              (id INT NOT NULL AUTO_INCREMENT,
                               name VARCHAR(255) NOT NULL,
                               price INT NOT NULL,
                               description VARCHAR(255) NOT NULL,
                               isHot VARCHAR(255) NOT NULL,
                               onSale VARCHAR(255) NOT NULL,
                               image VARCHAR(255) NOT NULL,
                               weight INT NOT NULL,
                               sellingPrice INT NOT NULL,
                               manufacturer VARCHAR(255) NOT NULL,
                               PRIMARY KEY (id));");
            return connection.Query<Products>("SELECT * FROM Products").ToList();
        }
        public List<Custumers> CreateCustumerTable(Custumers custumers)
        {
            connection.Execute(@"CREATE TABLE Custumers
                              (id INT NOT NULL AUTO_INCREMENT,
                               userName VARCHAR(255) NOT NULL,
                               password INT NOT NULL,
                               firstName VARCHAR(255) NOT NULL,
                               lastName VARCHAR(255) NOT NULL,
                               address VARCHAR(255) NOT NULL,
                               phone INT NOT NULL,
                               isMale VARCHAR(255) NOT NULL,
                               country VARCHAR(255) NOT NULL,
                               PRIMARY KEY (id));");
            return connection.Query<Custumers>("SELECT * FROM Custumers").ToList();


        }
        public List<Order> CreateOrderTable(Order order)
        {
            connection.Execute(@"CREATE TABLE `Order`
                              (id INT NOT NULL AUTO_INCREMENT,
                               CustumerId INT NOT NULL,
                               ProductId INT NOT NULL,
                               OrderDate INT NOT NULL,
                               OrderStatus INT NOT NULL,
                               OrderPrice INT NOT NULL,
                               ShippingDate INT NOT NULL,
                               ShippingStatus INT NOT NULL,
                               PRIMARY KEY (id));");
            return connection.Query<Order>("SELECT * FROM Order").ToList();


        }
        public List<Supplier> CreateSupplierTable(Supplier supplier)
        {
            connection.Execute(@"CREATE TABLE `Supplier`
                              (id INT NOT NULL AUTO_INCREMENT,
                               Name VARCHAR(255) NOT NULL,
                               ProductId INT NOT NULL,
                               ProductPrice INT NOT NULL,
                               OrderId INT NOT NULL,
                               PRIMARY KEY (id));");
            return connection.Query<Supplier>("SELECT * FROM Supplier").ToList();
        }
       public List <Payment> CreatePaymentTable(Payment payment)
        {
            connection.Execute(@"CREATE TABLE `Payment`
                              (id INT NOT NULL AUTO_INCREMENT,
                               OrderId INT NOT NULL,
                               Amount INT NOT NULL,
                               Provider INT NOT NULL,
                               Status INT NOT NULL,
                               CreatedAt INT NOT NULL,
                               PRIMARY KEY (id));");
            return connection.Query<Payment>("SELECT * FROM Payment").ToList();
        }
    }
}