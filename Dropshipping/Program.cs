namespace DropShipping
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabasManager db = new DatabasManager();
            Product products = new Product();
            Customers custumers = new Customers();
            DatabaseSeeder databaseSeeder = new DatabaseSeeder(db.connection);
            Order order = new Order();
            Supplier supplier = new Supplier();
            Payment payment = new Payment();
            Ui ui = new Ui();
            new StartMenu(ui).RunMainMenu();
            Products_To_Supplier products_To_Supplier = new Products_To_Supplier();
            Products_To_Order products_To_Order = new Products_To_Order();
            
            while (true)
            {
            /* databaseSeeder.CreateProducts_To_OrderTable(products_To_Order);
               databaseSeeder.CreateProducts_To_SupplierTable(products_To_Supplier); */
               //order.AddProduct(product);
              /*  db.GetProductsAndOrder(products, order); */
              // ui.CreateProduct(product);
               Product product = ui.ChooseProduct();
               ui.Showproduct(product);
               db.UpdateCustumers(custumers);
               new StartMenu(ui).RunMainMenu();
               
            
            }
        }
    }

}
