namespace DropShipping
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabasManager db = new DatabasManager();
            Products products = new Products();
            Customers custumers = new Customers();
            DatabaseSeeder databaseSeeder = new DatabaseSeeder(db.connection);
            Order order = new Order();
            Supplier supplier = new Supplier();
            Payment payment = new Payment();
            new StartMenu().RunMainMenu();
            Ui ui = new Ui();
            Products_To_Supplier products_To_Supplier = new Products_To_Supplier();
            Products_To_Order products_To_Order = new Products_To_Order();
            
            
           
                    
             
            while (true)
            {
            /* databaseSeeder.CreateProducts_To_OrderTable(products_To_Order);
               databaseSeeder.CreateProducts_To_SupplierTable(products_To_Supplier); */
               //order.AddProduct(product);
              /*  db.GetProductsAndOrder(products, order); */
              Products product = ui.ChooseProduct();
               new StartMenu().RunMainMenu();
               ui.Showproduct(product);
              // ui.CreateProduct(product);
               db.UpdateCustumers(custumers);

            
            }
        }
    }

}
