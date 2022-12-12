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

            
            
           
             
            while (true)
            {
               Products product = ui.ChooseProduct();
               ui.Showproduct(product);
               //order.AddProduct(product);
               db.UpdateCustumers(custumers);

            
            }
        }
    }

}
