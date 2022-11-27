namespace DropShipping
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabasManager db = new DatabasManager();
            Products products = new Products();
            Custumers custumers = new Custumers();
            DatabaseSeeder databaseSeeder = new DatabaseSeeder(db.connection);
            Order order = new Order();
            Supplier supplier = new Supplier();
           
              /*  Console.WriteLine("Hello World!"); */
            while (true)
            {
                 databaseSeeder.CreateOrderTable(order);
                databaseSeeder.CreateSupplierTable(supplier); 
                databaseSeeder.CreateProductTable(products);
                databaseSeeder.CreateCustumerTable(custumers); 
                
            }
        }
    }

}
